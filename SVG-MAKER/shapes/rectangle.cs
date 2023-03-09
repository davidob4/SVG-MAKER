[Serializable]
class rectangle : shapes
{
    public string s = "Rectangle";
    public string getShape()
    {
        return s;
    }
    private string ID, fill, stroke;
    private int x, y, width, height, strokewidth;
    public rectangle()
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();

        this.x = 10;
        this.y = 10;
        this.width = 15;
        this.height = 10;
        this.stroke = "black";
        this.strokewidth = 10;
        this.fill = "blue";
    }

    public rectangle(int x, int y, int width, int height, string stroke, int strokewidth, string fill)
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();

        this.fill = fill;
        this.stroke = stroke;
        this.strokewidth = strokewidth;
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public string getSVG()
    {
        return "<rect x=\"" + this.x + "\" " + "y=\"" + this.y + "\" " + "width=\"" + this.width + "\" " + "height=\"" + this.height + "\" " + " stroke=\"" + this.stroke + "\" stroke-width=\"" + this.strokewidth + "\" fill=\"" + this.fill + "\"/>\n";
    }

    public string getID()
    {
        return ID;
    }
}