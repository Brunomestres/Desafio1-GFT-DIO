
namespace projeto1.src.Entities{

  public class Ninja: Hero {
    public Ninja(string name, int level, string heroType): base(name, level, heroType){
      
    }

    public override string Attack()
    {
      return $"{this.name} atacou com uma shuriken!";
    }
  }
}