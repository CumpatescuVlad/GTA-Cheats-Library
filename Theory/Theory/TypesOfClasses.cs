namespace Basic
{
    //Normal Class
    public class NormalClass { }

    //Static class is a type of class which cannot be instantiated
    //therefore ypu cannot create an object out of this class
    //members of this class should be accesed with the name of the Class
    public static class StaticClass { }

    //This is a partial class
    //This class takes part from a set of classes in the same .cs file
    //then they will be compiled into one sg class
    public partial class PartialClass { }

    //This class is  made special to be inhertited 
    //it contains virtual or abstract methods taht can be ovverridden in a derived class
    //declaring abstract memebers and classes means that they have a lack of implementation
    public abstract class AbstractClass { }


    //this class cannot be inherited it was made to hold code secure

    public sealed class SealedClass { }

}
