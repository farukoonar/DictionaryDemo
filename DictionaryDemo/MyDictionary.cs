namespace DictionaryDemo
{
    class MyDictionary<T, P>
    {
        T[] keys; //key değerlerini tuttuğumuz array
        P[] values; //value değerlerini tuttuğumuz array

        public MyDictionary()
        {
            keys = new T[0];
            values = new P[0];
            //MyDictionary sınıfı newlendiği anda keys ve values değerlerimiz de eleman sayısı 0 olarak newlenmiş oluyor.
        }
        public void Add(T key,P value)
        {
            T[] tempKeys = keys; //keys arrayini newlemeden önce yedeğini alıyoruz.
            P[] tempValues = values; //values arrayini newlemeden önce yedeğini alıyoruz.

            keys = new T[keys.Length + 1]; //keys değerine yeni değer ekleyeceğimiz için eleman sayısını 1 arttırarak newliyoruz.
            values = new P[values.Length + 1]; //values değerine yeni değer ekleyeceğimiz için eleman sayısını 1 arttırarak newliyoruz.

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i]; //yedeğe aldığımız keys arrayini tekrar keys arrayine aktarıyoruz.
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i]; //yedeğe aldığımız values arrayini tekrar values arrayine aktarıyoruz.
            }
            
            keys[keys.Length-1] = key; //metot içindeki key değerini keys arrayine ekliyoruz.
            values[values.Length-1] = value; //metot içindeki value değerini values arrayine ekliyoruz.
        }
    }
    
}
