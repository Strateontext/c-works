public Form1()
        {
            this.KeyDown += new KeyEventHandler(keypressed);
        }

public void keypressed(object sender, KeyEventArgs e)
{
    switch (e.KeyCode)
    {
        case Keys.Up://w (haut)
            this.floatpanel.Location = new System.Drawing.Point(floatpanel.Location.X, floatpanel.Location.Y - 10);
            break;
        case Keys.Down://s (bas)
            this.floatpanel.Location = new System.Drawing.Point(floatpanel.Location.X, floatpanel.Location.Y + 10);
            break;
        case Keys.Right://d (droite)
            this.floatpanel.Location = new System.Drawing.Point(floatpanel.Location.X + 10, floatpanel.Location.Y);
            break;
        case Keys.Left: //a (gauche)
            this.floatpanel.Location = new System.Drawing.Point(floatpanel.Location.X - 10, floatpanel.Location.Y);
            break;
    }
}
