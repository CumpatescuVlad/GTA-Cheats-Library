namespace OOP
{
    public abstract class Abstraction
    {
        //Abstraction is the third OOP priciple where devs need to show only relevant information , making
        //the code more secure, with abstraction you can declare abstract classes taht have abstract members
        //abstract methods could be ovveridden in a derived class
        //Abstract methods have no body , they require an implementation via inhertiance.

        public abstract void CreateNumber();

        public abstract string ReturnSentance();

    }
}