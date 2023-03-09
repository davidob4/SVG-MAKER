class Canvas
{
    private HashSet<string> idHashSet = new HashSet<string>();
    private string svg;
    private List<shapes> els = new List<shapes>();
    private int width, height;
    private int order = 0;
    public Canvas(int width, int height)
    {
        this.width = width;
        this.height = height;
        svg = "<svg height=\"" + this.height + "\"" + " width=\"" + this.width + "\"" + ">\n</svg>";
    }

    public void addShape(shapes s)
    {
        idHashSet.Add(s.getID());
        els.Add(s);
        order++;
        reBuildSvg(els);
    }
    public void addShapeAtIndex(shapes s, int i){
        idHashSet.Add(s.getID());
        els.Insert(i, s);
        order++;
        reBuildSvg(els);
    }
    public void removeShape(string id)
    {
        idHashSet.Remove(id);
        for (int i = 0; i < els.Count; i++)
        {
            if (els[i].getID() == id)
            {
                els.RemoveAt(i);
                order--;
                break;
            }
        }
        reBuildSvg(els);
    }
    public void updateShape(string id, shapes s)
    {
        idHashSet.Remove(id);
        idHashSet.Add(s.getID());

        for (int i = 0; i < els.Count; i++)
        {
            if (els[i].getID() == id)
            {
                els[i] = s;
                break;
            }
        }
        reBuildSvg(els);
    }
    public void reBuildSvg(List<shapes> els)
    {
        svg = "<svg height=\"" + this.height + "\"" + " width=\"" + this.width + "\"" + ">\n";
        if (order != 0)
        {
            for (int i = 0; i < order; i++)
            {
                svg = svg + els[i].getSVG();
            }
        }
        svg = svg + "</svg>";
    }
    public string getSVG()
    {
        return svg;
    }
    public int elsLength()
    {
        return els.Count;
    }
    public shapes elsReturn(int i)
    {
        return els[i];
    }
    public int getWidth(){
        return this.width;
    }
    public int getHeight(){
        return this.height;
    }
}