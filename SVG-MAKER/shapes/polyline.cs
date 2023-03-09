[Serializable]
class polyLine : shapes
{
    public string s = "PolyLine";
    public string getShape()
    {
        return s;
    }
    private string ID, order = "", stroke;
    private int strokewidth;

    public polyLine()
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();
        this.stroke = "black";
        this.strokewidth = 1;
        this.order = "1,1 2,2 3,3 4,4 5,5";
    }
    public polyLine(List<line> l, string stroke, int strokewidth)
    {
        Guid myuuid = Guid.NewGuid();
        this.ID = myuuid.ToString();
        this.stroke = stroke;
        this.strokewidth = strokewidth;

        for (int i = 0; i < l.Count; i++)
        {
            order = order + l[i].getx1() + "," + l[i].gety1() + " ";
        }
        order = order + l[l.Count - 1].getx2() + "," + l[l.Count - 1].gety2();
    }
    public string getSVG()
    {
        return "<polyline points=\"" + this.order + "\" " + " stroke=\"" + this.stroke + "\" stroke-width=\"" + this.strokewidth + "\"/>\n";
    }

    public string getID()
    {
        return ID;
    }
}