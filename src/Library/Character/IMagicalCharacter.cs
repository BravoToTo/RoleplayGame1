using System;
namespace Library;

public interface IMagicalCharacter:ICharacter
{
    //void AddSpell(ISpell spell);
    //void RemoveSpell(ISpell spell);
    void AddItem(IMagicalItem item);
    void RemoveItem(IMagicalItem item);

    
}