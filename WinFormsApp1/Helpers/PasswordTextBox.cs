using System.ComponentModel;

namespace WinFormsApp1.Helpers
{
    /// <summary>
    /// Controllo personalizzato che mostra una TextBox con:
    /// - Placeholder (testo grigio quando vuota)
    /// - Emoji 🙈/🙉 per mostrare o nascondere la password
    /// - Bordo disegnato manualmente
    /// </summary>
    public class PasswordTextBox : UserControl
    {
        // TextBox interna che contiene il vero testo digitato dall’utente
        private TextBox txt;

        // Stato della password: true = visibile, false = nascosta
        private bool mostraPassword = false;

        public PasswordTextBox()
        {
            // Dimensioni del controllo esterno
            this.Height = 34;
            this.Width = 240;

            // Colore di sfondo del controllo (non della TextBox interna)
            this.BackColor = Color.White;

            // Padding: lascia un piccolo margine interno
            this.Padding = new Padding(1);

            // INIZIALIZZAZIONE DELLA TEXTBOX INTERNA
            txt = new TextBox
            {
                // Rimuove il bordo standard della TextBox
                BorderStyle = BorderStyle.None,

                // Nasconde il testo con ●●●
                UseSystemPasswordChar = true,

                // Font testuale
                Font = new Font("Segoe UI", 10f),

                // Posizione della TextBox interna dentro il controllo
                Location = new Point(8, 9),

                // Larghezza della TextBox interna (il controllo totale - spazio per emoji)
                Width = this.Width - 40,

                // Colore del testo quando l'utente scrive
                ForeColor = Color.Black
            };

            // Ogni volta che cambia testo → ridisegna (per gestire placeholder)
            txt.TextChanged += (s, e) => Invalidate();

            // Aggiunge la TextBox interna al controllo principale
            Controls.Add(txt);
        }

        /// <summary>
        /// Testo mostrato come placeholder quando la TextBox è vuota.
        /// </summary>
        [Category("Appearance")]
        public string Placeholder { get; set; } = "Password";

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;

            // -------------------------------
            // 1) BORDO DEL CONTROLLO
            // -------------------------------
            using (var pen = new Pen(Color.Gray, 1.6f))
                g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);

            // -------------------------------
            // 2) PLACEHOLDER
            // -------------------------------
            // Mostrato solo se:
            // - il testo è vuoto
            // - la TextBox non ha il focus
            if (string.IsNullOrWhiteSpace(txt.Text) && !txt.Focused)
            {
                TextRenderer.DrawText(
                    g,
                    Placeholder,
                    txt.Font,
                    new Point(8, 8),   // posizione placeholder
                    Color.Gray         // colore placeholder
                );
            }

            // -------------------------------
            // 3) EMOJI MOSTRA/NASCONDI
            // -------------------------------
            // 🙈 = password nascosta
            // 🙉 = password visibile
            TextRenderer.DrawText(
                g,
                mostraPassword ? "🙉" : "🙈",
                txt.Font,
                new Point(Width - 28, 8),    // posizione dell'emoji
                Color.Gray
            );
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            // Area cliccabile: lato destro dove c’è l’emoji
            var areaIcona = new Rectangle(Width - 35, 0, 35, Height);

            // Se clicchi sull'emoji
            if (areaIcona.Contains(e.Location))
            {
                // Inverto lo stato della visibilità
                mostraPassword = !mostraPassword;

                // Applica la visibilità alla TextBox interna
                txt.UseSystemPasswordChar = !mostraPassword;

                // Ridisegna per cambiare emoji
                Invalidate();
            }
            else
            {
                // Se clicchi altrove → dai focus alla TextBox interna
                txt.Focus();
            }
        }

        /// <summary>
        /// Proprietà pubblica per leggere/scrivere il valore della password.
        /// È meglio NON sovrascrivere la proprietà Text del controllo base.
        /// </summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override string Text
        {
            get => txt.Text;
            set
            {
                txt.Text = value;
                Invalidate(); // Aggiorna placeholder e UI
            }
        }
    }
}
