namespace FirstCSOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 1

            // instantiate an object of Dog
            Dog dog = new Dog("Charlie");
            dog.move();
            dog.sleep();
            dog.eat();
            dog.sing();
            dog.wash();
            dog.turnAround();


            // instantiate an object of Cat
            Cat cat = new Cat("Kovu");
            cat.move();
            cat.sleep();
            cat.eat();
            cat.sing();
            cat.wash();
            cat.turnAround();

            // instantiate an object of Bird
            Bird bird = new Bird("Blu");
            bird.move();
            bird.sleep();
            bird.eat();
            bird.sing();
            bird.wash();
            bird.turnAround();


            // part 2
            // instatiate an object of SmallCraft
            SmallCraft small = new SmallCraft();
            small.fly();
            small.goToHyperspace();
            small.land();

            // instatiate an object of LargeCraft
            LargeCraft large = new LargeCraft();
            large.fly();
            large.goToHyperspace();
            large.land();

            // instatiate an object of BossCraft
            BossCraft boss = new BossCraft();
            boss.fly();
            boss.goToHyperspace();
            boss.land();

            // pause application at the end of execution
            Console.ReadKey();
        }

    }
}
