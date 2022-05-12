
namespace projeto1.src.Entities{

  public class BlackWizard: Hero {
    public BlackWizard(string name, int level, string heroType): base(name, level, heroType){
      
    }

    public override string Attack()
    {
      return $"{this.name} atacou com uma magia necromante!";
    }
  }
}