namespace PokedexForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imagePokemon = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NombrePokemon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoPokemon = new System.Windows.Forms.Label();
            this.PokemonFront = new System.Windows.Forms.PictureBox();
            this.PokemonBack = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hp_Pokemon = new System.Windows.Forms.Label();
            this.speed_Pokemon = new System.Windows.Forms.Label();
            this.atq_Pokemon = new System.Windows.Forms.Label();
            this.def_Pokemon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.weight_pokemon = new System.Windows.Forms.Label();
            this.BuscarPokemon = new System.Windows.Forms.TextBox();
            this.SeachPokemon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePokemon
            // 
            this.imagePokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imagePokemon.Location = new System.Drawing.Point(127, 117);
            this.imagePokemon.Name = "imagePokemon";
            this.imagePokemon.Size = new System.Drawing.Size(180, 89);
            this.imagePokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePokemon.TabIndex = 0;
            this.imagePokemon.TabStop = false;
            this.imagePokemon.Click += new System.EventHandler(this.imagePokemon_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.ForeColor = System.Drawing.Color.Transparent;
            this.NextButton.Location = new System.Drawing.Point(313, 347);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(36, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.TabStop = false;
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.BackColor = System.Drawing.Color.Transparent;
            this.PrevButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevButton.ForeColor = System.Drawing.Color.Transparent;
            this.PrevButton.Location = new System.Drawing.Point(280, 347);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(36, 23);
            this.PrevButton.TabIndex = 2;
            this.PrevButton.TabStop = false;
            this.PrevButton.UseVisualStyleBackColor = false;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NombrePokemon
            // 
            this.NombrePokemon.AutoSize = true;
            this.NombrePokemon.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePokemon.Location = new System.Drawing.Point(124, 213);
            this.NombrePokemon.Name = "NombrePokemon";
            this.NombrePokemon.Size = new System.Drawing.Size(55, 13);
            this.NombrePokemon.TabIndex = 3;
            this.NombrePokemon.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type:";
            // 
            // tipoPokemon
            // 
            this.tipoPokemon.AutoSize = true;
            this.tipoPokemon.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPokemon.Location = new System.Drawing.Point(263, 213);
            this.tipoPokemon.Name = "tipoPokemon";
            this.tipoPokemon.Size = new System.Drawing.Size(35, 12);
            this.tipoPokemon.TabIndex = 5;
            this.tipoPokemon.Text = "Tipo:";
            // 
            // PokemonFront
            // 
            this.PokemonFront.BackColor = System.Drawing.Color.Transparent;
            this.PokemonFront.Location = new System.Drawing.Point(511, 104);
            this.PokemonFront.Name = "PokemonFront";
            this.PokemonFront.Size = new System.Drawing.Size(70, 58);
            this.PokemonFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PokemonFront.TabIndex = 6;
            this.PokemonFront.TabStop = false;
            // 
            // PokemonBack
            // 
            this.PokemonBack.BackColor = System.Drawing.Color.Transparent;
            this.PokemonBack.Location = new System.Drawing.Point(511, 160);
            this.PokemonBack.Name = "PokemonBack";
            this.PokemonBack.Size = new System.Drawing.Size(70, 58);
            this.PokemonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PokemonBack.TabIndex = 7;
            this.PokemonBack.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Attack:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Defense:";
            // 
            // hp_Pokemon
            // 
            this.hp_Pokemon.AutoSize = true;
            this.hp_Pokemon.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp_Pokemon.Location = new System.Drawing.Point(660, 117);
            this.hp_Pokemon.Name = "hp_Pokemon";
            this.hp_Pokemon.Size = new System.Drawing.Size(14, 13);
            this.hp_Pokemon.TabIndex = 12;
            this.hp_Pokemon.Text = "0";
            // 
            // speed_Pokemon
            // 
            this.speed_Pokemon.AutoSize = true;
            this.speed_Pokemon.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_Pokemon.Location = new System.Drawing.Point(660, 137);
            this.speed_Pokemon.Name = "speed_Pokemon";
            this.speed_Pokemon.Size = new System.Drawing.Size(14, 13);
            this.speed_Pokemon.TabIndex = 13;
            this.speed_Pokemon.Text = "0";
            // 
            // atq_Pokemon
            // 
            this.atq_Pokemon.AutoSize = true;
            this.atq_Pokemon.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atq_Pokemon.Location = new System.Drawing.Point(660, 173);
            this.atq_Pokemon.Name = "atq_Pokemon";
            this.atq_Pokemon.Size = new System.Drawing.Size(14, 13);
            this.atq_Pokemon.TabIndex = 14;
            this.atq_Pokemon.Text = "0";
            // 
            // def_Pokemon
            // 
            this.def_Pokemon.AutoSize = true;
            this.def_Pokemon.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.def_Pokemon.Location = new System.Drawing.Point(660, 193);
            this.def_Pokemon.Name = "def_Pokemon";
            this.def_Pokemon.Size = new System.Drawing.Size(14, 13);
            this.def_Pokemon.TabIndex = 15;
            this.def_Pokemon.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(701, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Weight";
            // 
            // weight_pokemon
            // 
            this.weight_pokemon.AutoSize = true;
            this.weight_pokemon.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_pokemon.Location = new System.Drawing.Point(701, 160);
            this.weight_pokemon.Name = "weight_pokemon";
            this.weight_pokemon.Size = new System.Drawing.Size(49, 13);
            this.weight_pokemon.TabIndex = 17;
            this.weight_pokemon.Text = "Weight";
            // 
            // BuscarPokemon
            // 
            this.BuscarPokemon.BackColor = System.Drawing.Color.White;
            this.BuscarPokemon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuscarPokemon.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPokemon.ForeColor = System.Drawing.Color.Red;
            this.BuscarPokemon.Location = new System.Drawing.Point(184, 349);
            this.BuscarPokemon.Name = "BuscarPokemon";
            this.BuscarPokemon.Size = new System.Drawing.Size(82, 12);
            this.BuscarPokemon.TabIndex = 18;
            // 
            // SeachPokemon
            // 
            this.SeachPokemon.BackColor = System.Drawing.Color.Transparent;
            this.SeachPokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeachPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeachPokemon.ForeColor = System.Drawing.Color.Transparent;
            this.SeachPokemon.Location = new System.Drawing.Point(109, 339);
            this.SeachPokemon.Name = "SeachPokemon";
            this.SeachPokemon.Size = new System.Drawing.Size(36, 23);
            this.SeachPokemon.TabIndex = 19;
            this.SeachPokemon.TabStop = false;
            this.SeachPokemon.UseVisualStyleBackColor = false;
            this.SeachPokemon.Click += new System.EventHandler(this.SeachPokemon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 479);
            this.Controls.Add(this.SeachPokemon);
            this.Controls.Add(this.BuscarPokemon);
            this.Controls.Add(this.weight_pokemon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.def_Pokemon);
            this.Controls.Add(this.atq_Pokemon);
            this.Controls.Add(this.speed_Pokemon);
            this.Controls.Add(this.hp_Pokemon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PokemonBack);
            this.Controls.Add(this.PokemonFront);
            this.Controls.Add(this.tipoPokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombrePokemon);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.imagePokemon);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.imagePokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePokemon;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Label NombrePokemon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tipoPokemon;
        private System.Windows.Forms.PictureBox PokemonFront;
        private System.Windows.Forms.PictureBox PokemonBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hp_Pokemon;
        private System.Windows.Forms.Label speed_Pokemon;
        private System.Windows.Forms.Label atq_Pokemon;
        private System.Windows.Forms.Label def_Pokemon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label weight_pokemon;
        private System.Windows.Forms.TextBox BuscarPokemon;
        private System.Windows.Forms.Button SeachPokemon;
    }
}

