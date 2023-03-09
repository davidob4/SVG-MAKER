class AddShapeCommand : Command{
    private Canvas canvas;
    private shapes s;
    public AddShapeCommand(Canvas c, shapes s){
        this.canvas = c;
        this.s = s;
    }
    public void Execute(){
        canvas.addShape(s);
    }
    public void UnExecute(){
        canvas.removeShape(s.getID());
    }
}