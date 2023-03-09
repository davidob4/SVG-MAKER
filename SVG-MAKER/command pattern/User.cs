class User{
    private Stack<Command> commands_undo_stack = new Stack<Command>();
    private Stack<Command> commands_redo_stack = new Stack<Command>();
    public void addCommand(Command command){
        commands_undo_stack.Push(command);
        command.Execute();
    }
    public void undo(){
        commands_undo_stack.Peek().UnExecute();
        commands_redo_stack.Push(commands_undo_stack.Pop());
    }
    public void redo(){
        commands_redo_stack.Peek().Execute();
        commands_undo_stack.Push(commands_redo_stack.Pop());
    }
}