using SystemComponents.Singleton;

namespace SystemComponents.Providers{
    public class FemaleProvider{
        private StoreSingleton _store ;

        public FemaleProvider(){
            _store = StoreSingleton.getInstance();

            _store.AddName("Samah");
            _store.AddName("Manal");
            _store.AddName("Hend");
        }

        public StoreSingleton getStoreSingleton(){
            return _store ;
        }
    }
}