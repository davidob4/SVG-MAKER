class DeleteShapeCommand : Command{
    private Canvas canvas;
    private string id;
    private shapes s;
    private int index;
    public DeleteShapeCommand(Canvas c, int n){
        this.canvas = c;
        this.id = c.elsReturn(n - 1).getID();
        this.s = canvas.elsReturn(n - 1);
        this.index = n - 1;
    }
    public void Execute(){
        canvas.removeShape(id);
    }
    public void UnExecute(){
        canvas.addShapeAtIndex(s, index);
    }
}