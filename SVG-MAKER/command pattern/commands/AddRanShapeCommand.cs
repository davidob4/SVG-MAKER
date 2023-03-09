class AddRanShapeCommand : Command{
    private Canvas canvas;
    private shapes s;
    public AddRanShapeCommand(Canvas c){
        this.canvas = c;
        this.s = ranShape.genRanShape(c.getWidth(), c.getHeight());
    }
    public void Execute(){
        canvas.addShape(s);
    }

    public void UnExecute(){
        canvas.removeShape(s.getID());
    }
}