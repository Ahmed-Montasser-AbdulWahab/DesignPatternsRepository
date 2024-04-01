
namespace SystemComponents.Singleton{
    public class StoreSingleton{
        private static StoreSingleton _store ;
        private List<string> names ;
        

        private StoreSingleton(){
            names = new List<string>();
        }

        public static StoreSingleton getInstance(){
            if(_store == null){
                _store = new StoreSingleton();
            }

            return _store;
        }

        public void AddName(string name){
            names.Add(name);
        }

        public bool RemoveName(string name){
            return names.Remove(name);
        }

        public void PrintNames(){
            names.ForEach(Console.WriteLine);
        }
    }
}