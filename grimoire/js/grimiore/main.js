function main() {
  console.log("Do you believe in magic?");
  console.log("------------------------");

  const allSpells = [
    {
      Name: "Turn enemy into a newt",
      IsEvil: true,
      EnergyReqired: 5.1
    },
    {
      Name: "Conjure some gold for a local charity",
      IsEvil: false,
      EnergyReqired: 2.99
    },
    {
      Name: "Give a deaf person the ability to heal",
      IsEvil: false,
      EnergyReqired: 12.2
    },
    {
      Name: "Make yourself emperor of the universe",
      IsEvil: true,
      EnergyReqired: 100.0
    },
    {
      Name: "Convince your relatives your political views are correct",
      IsEvil: false,
      EnergyReqired: 2921.5
    }
  ]

  const GoodSpellBook = {
      Title: "Good Book",
      Spells: allSpells.filter(spell => spell.IsEvil === false)
    }


  const EvilSpellBook ={
      Title: "Evil Book",
      Spells: allSpells.filter(spell => spell.IsEvil)
    }


  const DisplaySpellBook = (spellBook) => {
    console.log(spellBook.Title)
    for (const spell of spellBook.Spells){
      console.log(spell.Name)
    }
  }

  DisplaySpellBook(GoodSpellBook)
  console.log("")
  DisplaySpellBook(EvilSpellBook)
}

main();