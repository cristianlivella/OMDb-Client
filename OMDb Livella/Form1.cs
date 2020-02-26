using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMDb_Livella
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        static List<Movie> movies = new List<Movie>();
        const string API_KEY = "be7b1bec";
        static IDictionary<string, string> TYPE_TRANSLATION = new Dictionary<string, string> { { "movie", "film" }, { "series", "serie" }, { "episode", "episodio" }, { "game", "gioco" } };

        public Form1()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://omdbapi.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            resultsToGet.SelectedIndex = 1;
            pictureBox.Image = Properties.Resources.no_image;
        }
        public static async Task<MoviesSearch> searchMovies(string title, int page)
        {
            MoviesSearch movies = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync("/?apikey=" + API_KEY + "&s=" + title + "&page=" + page.ToString());
                if (response.IsSuccessStatusCode)
                {
                    movies = await response.Content.ReadAsAsync<MoviesSearch>();
                }
            }
            catch {}
            return movies;
        }

        public static async Task<MovieDetails> getMovieDetails(string id)
        {
            MovieDetails movie = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync("/?apikey=" + API_KEY + "&i=" + id);
                if (response.IsSuccessStatusCode)
                {
                    movie = await response.Content.ReadAsAsync<MovieDetails>();
                }
            }
            catch { }
            return movie;
        }

        public Image getImage(string url)
        {
            Image img;
            try
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(url);
                MemoryStream ms = new MemoryStream(bytes);
                img = Image.FromStream(ms);
            }
            catch
            {
                img = Properties.Resources.no_image;
            }
            return img;
        }

        private void disableSearch()
        {
            searchBtn.Enabled = false;
            searchTxt.Enabled = false;
            movieList.Enabled = false;
            resultsToGet.Enabled = false;
        }

        private void enableSearch()
        {
            searchBtn.Enabled = true;
            searchTxt.Enabled = true;
            movieList.Enabled = true;
            resultsToGet.Enabled = true;
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTxt.Text))
            {
                MessageBox.Show("Inserisci il titolo del film che vuoi cercare", "Errore");
                return;
            }
            int totalResults = 10, gotResults = 0, toGet = int.Parse(resultsToGet.SelectedItem.ToString()), page = 1;
            disableSearch();
            movies = new List<Movie>();
            while (gotResults<Math.Min(totalResults, toGet))
            {
                MoviesSearch result = await searchMovies(searchTxt.Text, page++);
                if (result == null)
                {
                    MessageBox.Show("Impossibile comunicare con il server", "Errore");
                    enableSearch();
                    return;
                }
                else if (result.Search == null)
                {
                    MessageBox.Show("Nessun film trovato", "Errore");
                    enableSearch();
                    return;
                }
                gotResults += result.Search.Count();
                totalResults = int.Parse(result.totalResults);
                movies.AddRange(result.Search);
            }
            enableSearch();
            refreshMovieList();
        }

        private void refreshMovieList()
        {
            movieList.Items.Clear();
            movieImageList.Images.Clear();
            foreach (Movie movie in movies)
            {
                movieImageList.Images.Add(movie.imdbID, getImage(movie.Poster));
                movieList.Items.Add(movie.Title, movie.imdbID);
                movieList.Items[movieList.Items.Count - 1].SubItems.Add(movie.Year);
                movieList.Items[movieList.Items.Count - 1].SubItems.Add(TYPE_TRANSLATION[movie.Type]);
                movieList.Items[movieList.Items.Count - 1].SubItems.Add(movie.Poster);
            }
            movieList.Focus();
            movieList.Items[0].Selected = true;
        }

        private void tileViewBtn_Click(object sender, EventArgs e)
        {
            movieList.View = View.LargeIcon;
            tileViewBtn.Enabled = false;
            detailsViewBtn.Enabled = true;
            refreshMovieList();
        }

        private void detailsViewBtn_Click(object sender, EventArgs e)
        {
            movieList.View = View.Details;
            detailsViewBtn.Enabled = false;
            tileViewBtn.Enabled = true;
        }

        private async void movieList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
                return;
            pictureBox.Image = getImage(e.Item.SubItems[3].Text);
            MovieDetails result = await getMovieDetails(e.Item.ImageKey);
            if (result==null)
            {
                MessageBox.Show("Impossibile comunicare con il server", "Errore");
                return;
            }
            titoloContentLabel.Text = result.Title;
            produzioneContentLabel.Text = result.Production;
            regiaContentLabel.Text = result.Director;
            statoContentLabel.Text = result.Country;
            annoContentLabel.Text = result.Year;
            dvdContentLabel.Text = result.DVD;
            tipoContentLabel.Text = result.Type;
            durataContentLabel.Text = result.Runtime;
            tramaContentLabel.Text = result.Plot;
        }
    }
}
