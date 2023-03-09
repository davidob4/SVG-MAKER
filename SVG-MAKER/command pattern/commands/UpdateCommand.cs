class UpdateCommand : Command{
    private Canvas canvas;
    private shapes s, og_shape;
    private int n;
    public UpdateCommand(Canvas c, shapes s, int n){
        this.canvas = c;
        this.n = n;
        this.s = s;
        this.og_shape = c.elsReturn(n);
    }
    public void Execute(){
        canvas.updateShape(canvas.elsReturn(n).getID(), s);
    }
    public void UnExecute(){
        canvas.updateShape(s.getID(), og_shape);
    }
}