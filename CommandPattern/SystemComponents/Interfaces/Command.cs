namespace SystemComponents.Interfaces{
    public interface Command {
        public Task execute();

        // public void undo();
    }
}