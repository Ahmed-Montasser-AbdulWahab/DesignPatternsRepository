namespace SystemComponents.Interfaces{
    public interface API {
        public Task<Dictionary<string, object>?> getData();
    }
}