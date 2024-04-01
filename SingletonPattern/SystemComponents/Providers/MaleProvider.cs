using SystemComponents.Singleton;

namespace SystemComponents.Providers{
    public class MaleProvider{
        private StoreSingleton _store ;

        public MaleProvider(){
            _store = StoreSingleton.getInstance();

            _store.AddName("Ahmed");
            _store.AddName("Mohammed");
            _store.AddName("Hamed");
        }

        public StoreSingleton getStoreSingleton(){
            return _store ;
        }
    }
}