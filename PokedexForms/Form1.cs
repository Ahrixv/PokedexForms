using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexForms
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokeList = new List<Pokemon>();
        int i = 1;
        int pag = 1;
        public Form1()
        {
            InitializeComponent();
            ReadApi(i);
            BuscarPokemon.BackColor = Color.FromArgb(75, 219, 107);
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            NextButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            PrevButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            PrevButton.FlatAppearance.BorderSize = 0;
            PrevButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SeachPokemon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            SeachPokemon.FlatAppearance.BorderSize = 0;
            SeachPokemon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            NombrePokemon.Text = pokeList[0].Name;
            imagePokemon.Load(pokeList[0].Sprites.Other.OfficialArtwork.FrontDefault.ToString());
            hp_Pokemon.Text = pokeList[0].Stats[0].BaseStat.ToString();
            speed_Pokemon.Text = pokeList[0].Stats[5].BaseStat.ToString();
            atq_Pokemon.Text = pokeList[0].Stats[1].BaseStat.ToString();
            def_Pokemon.Text = pokeList[0].Stats[2].BaseStat.ToString();
            tipoPokemon.Text = pokeList[0].Types[0].Type.Name.ToString();
            PokemonFront.Load(pokeList[0].Sprites.FrontDefault.ToString());
            PokemonBack.Load(pokeList[0].Sprites.BackDefault.ToString());
            weight_pokemon.Text = $"{pokeList[0].Weight.ToString()} hg";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (pokeList.Count()==i)
            {
                ReadApi(i++);
                pag++;
                NombrePokemon.Text = pokeList[i-1].Name;
                imagePokemon.Load(pokeList[i-1].Sprites.Other.OfficialArtwork.FrontDefault.ToString());
                hp_Pokemon.Text = pokeList[i-1].Stats[0].BaseStat.ToString();
                speed_Pokemon.Text = pokeList[i-1].Stats[5].BaseStat.ToString();
                atq_Pokemon.Text = pokeList[i-1].Stats[1].BaseStat.ToString();
                def_Pokemon.Text = pokeList[i-1].Stats[2].BaseStat.ToString();
                tipoPokemon.Text = pokeList[i-1].Types[0].Type.Name.ToString();
                PokemonFront.Load(pokeList[i - 1].Sprites.FrontDefault.ToString());
                PokemonBack.Load(pokeList[i - 1].Sprites.BackDefault.ToString());
                weight_pokemon.Text = $"{pokeList[i - 1].Weight.ToString()} hg";
            }
            else
            {
                pag++;
                i++;
                NombrePokemon.Text = pokeList[i - 1].Name;
                imagePokemon.Load(pokeList[i - 1].Sprites.Other.OfficialArtwork.FrontDefault.ToString());
                hp_Pokemon.Text = pokeList[i - 1].Stats[0].BaseStat.ToString();
                speed_Pokemon.Text = pokeList[i - 1].Stats[5].BaseStat.ToString();
                atq_Pokemon.Text = pokeList[i - 1].Stats[1].BaseStat.ToString();
                def_Pokemon.Text = pokeList[i - 1].Stats[2].BaseStat.ToString();
                tipoPokemon.Text = pokeList[i - 1].Types[0].Type.Name.ToString();
                PokemonFront.Load(pokeList[i - 1].Sprites.FrontDefault.ToString());
                PokemonBack.Load(pokeList[i - 1].Sprites.BackDefault.ToString());
                weight_pokemon.Text = $"{pokeList[i - 1].Weight.ToString()} hg";
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (pag>1)
            {
                i--;
                NombrePokemon.Text = pokeList[i-1].Name;
                imagePokemon.Load(pokeList[i-1].Sprites.Other.OfficialArtwork.FrontDefault.ToString());
                hp_Pokemon.Text = pokeList[i - 1].Stats[0].BaseStat.ToString();
                speed_Pokemon.Text = pokeList[i - 1].Stats[5].BaseStat.ToString();
                atq_Pokemon.Text = pokeList[i - 1].Stats[1].BaseStat.ToString();
                def_Pokemon.Text = pokeList[i - 1].Stats[2].BaseStat.ToString();
                tipoPokemon.Text = pokeList[i - 1].Types[0].Type.Name.ToString();
                PokemonFront.Load(pokeList[i - 1].Sprites.FrontDefault.ToString());
                PokemonBack.Load(pokeList[i - 1].Sprites.BackDefault.ToString());
                weight_pokemon.Text = $"{pokeList[i - 1].Weight.ToString()} hg";
                pag--;
            }
        }

        private void imagePokemon_Click(object sender, EventArgs e)
        {

        }
        private void ReadApi(int i)
        {
            var webRequest = WebRequest.Create($"https://pokeapi.co/api/v2/pokemon/{i}") as HttpWebRequest;
            if (webRequest == null)
            {
                return;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    var contributors = JsonConvert.DeserializeObject<Pokemon>(contributorsAsJson);
                    pokeList.Add(contributors);
                }
            }
        }

        private void SeachPokemon_Click(object sender, EventArgs e)
        {

            SearchPokemonByName(BuscarPokemon.Text.ToLower());
            BuscarPokemon.Text = "";
        }
        private void SearchPokemonByName(string x)
        {
            try
            {
                var webRequest = WebRequest.Create($"https://pokeapi.co/api/v2/pokemon/{x}") as HttpWebRequest;
                webRequest.ContentType = "application/json";
                webRequest.UserAgent = "Nothing";

                using (var s = webRequest.GetResponse().GetResponseStream())
                {
                    using (var sr = new StreamReader(s))
                    {
                        var contributorsAsJson = sr.ReadToEnd();
                        var contributors = JsonConvert.DeserializeObject<Pokemon>(contributorsAsJson);
                        NombrePokemon.Text = contributors.Name;
                        imagePokemon.Load(contributors.Sprites.Other.OfficialArtwork.FrontDefault.ToString());
                        hp_Pokemon.Text = contributors.Stats[0].BaseStat.ToString();
                        speed_Pokemon.Text = contributors.Stats[5].BaseStat.ToString();
                        atq_Pokemon.Text = contributors.Stats[1].BaseStat.ToString();
                        def_Pokemon.Text = contributors.Stats[2].BaseStat.ToString();
                        tipoPokemon.Text = contributors.Types[0].Type.Name.ToString();
                        PokemonFront.Load(contributors.Sprites.FrontDefault.ToString());
                        PokemonBack.Load(contributors.Sprites.BackDefault.ToString());
                        weight_pokemon.Text = $"{contributors.Weight.ToString()} hg";
                    }
                }
            }
            catch
            {
                NombrePokemon.Text = "Unknown";
                imagePokemon.Image = null;
                hp_Pokemon.Text = "0";
                speed_Pokemon.Text = "0";
                atq_Pokemon.Text = "0";
                def_Pokemon.Text = "0";
                tipoPokemon.Text = "";
                PokemonFront.Image = null;
                PokemonBack.Image = null;
                weight_pokemon.Text = $"0 hg";
            }
        }
    }
}
