
namespace projeto1.src.Entities{

  public class Knight: Hero {
    public Knight(string name, int level, string heroType): base(name, level, heroType){
      
    }


    public override string Attack()
    {
      return $"{this.name} atacou com a montante!";
    }
  }
}