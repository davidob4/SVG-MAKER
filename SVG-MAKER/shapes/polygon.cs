[Serializable]
class polyGon : shapes
{
    public string s = "PolyGon";
    public string getShape()
    {
        return s;
    }
    private string ID, order = "", stroke, fill;
    private int strokewidth;
    public polyGon()
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();
        this.stroke = "black";
        this.strokewidth = 1;
        this.fill = "blue";
        this.order = "200,10 250,190 160,210";
    }
    public polyGon(List<line> l, string stroke, int strokewidth, string fill)
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();
        this.stroke = stroke;
        this.strokewidth = strokewidth;
        this.fill = fill;

        for (int i = 0; i < l.Count; i++)
        {
            order = order + l[i].getx1() + "," + l[i].gety1() + " ";
        }
        order = order + l[l.Count - 1].getx2() + "," + l[l.Count - 1].gety2();
    }
    public string getSVG()
    {
        return "<polygon points=\"" + this.order + "\" " + " stroke=\"" + this.stroke + "\" stroke-width=\"" + this.strokewidth + "\" fill=\"" + this.fill + "\"/>\n";
    }

    public string getID()
    {
        return ID;
    }
}