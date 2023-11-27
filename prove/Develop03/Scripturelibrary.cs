public class ScriptureLibrary
{
    private List<Scripture> scriptures;

    public ScriptureLibrary()
    {
        // Adding different scriptures to the library.
        scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), new List<Word>
            {
                new Word("For"),
                new Word("God"),
                new Word("so"),
                new Word("loved"),
                new Word("the"),
                new Word("world,"),
                new Word("that"),
                new Word("he"),
                new Word("gave"),
                new Word("his"),
                new Word("only"),
                new Word("Son,"),
                new Word("that"),
                new Word("whoever"),
                new Word("believes"),
                new Word("in"),
                new Word("him"),
                new Word("should"),
                new Word("not"),
                new Word("perish"),
                new Word("but"),
                new Word("have"),
                new Word("eternal"),
                new Word("life."),
            }),

            new Scripture(new Reference("Genesis", 1, 1), new List<Word>
            {
                new Word("In"),
                new Word("the"),
                new Word("beginning"),
                new Word("God"),
                new Word("created"),
                new Word("the"),
                new Word("heaven"),
                new Word("and"),
                new Word("the"),
                new Word("earth"),
            }),

            new Scripture(new Reference("1 Nephi", 3, 7), new List<Word>
            {
                new Word("I"),
                new Word("will"),
                new Word("go"),
                new Word("and"),
                new Word("do"),
                new Word("the"),
                new Word("things"),
                new Word("which"),
                new Word("the"),
                new Word("Lord"),
                new Word("hath"),
                new Word("commanded"),
                new Word("me."),
            }),

            new Scripture(new Reference("Helaman", 5, 12), new List<Word>
            {
                new Word("And"),
                new Word("now,"),
                new Word("my"),
                new Word("sons,"),
                new Word("remember,"),
                new Word("remember"),
                new Word("that"),
                new Word("it"),
                new Word("is"),
                new Word("upon"),
                new Word("the"),
                new Word("rock"),
                new Word("of"),
                new Word("our"),
                new Word("Redeemer,"),
                new Word("who"),
                new Word("is"),
                new Word("Christ,"),
                new Word("the"),
                new Word("Son"),
                new Word("of"),
                new Word("God,"),
                new Word("that"),
                new Word("ye"),
                new Word("must"),
                new Word("build"),
                new Word("your"),
                new Word("foundation,"),
                new Word("that"),
                new Word("when"),
                new Word("the"),
                new Word("devil"),
                new Word("shall"),
                new Word("send"),
                new Word("forth"),
                new Word("his"),
                new Word("mighty"),
                new Word("winds,"),
                new Word("yea,"),
                new Word("his"),
                new Word("shaft"),
                new Word("in"),
                new Word("the"),
                new Word("whirlwind,"),
                new Word("yea,"),
                new Word("when"),
                new Word("all"),
                new Word("his"),
                new Word("hail"),
                new Word("and"),
                new Word("his"),
                new Word("mighty"),
                new Word("storm"),
                new Word("shall"),
                new Word("beat"),
                new Word("upon"),
                new Word("you,"),
                new Word("it"),
                new Word("shall"),
                new Word("have"),
                new Word("no"),
                new Word("power"),
                new Word("over"),
                new Word("you"),
                new Word("to"),
                new Word("drag"),
                new Word("you"),
                new Word("down"),
                new Word("to"),
                new Word("the"),
                new Word("gulf"),
                new Word("of"),
                new Word("misery"),
                new Word("and"),
                new Word("endless"),
                new Word("wo,"),
                new Word("because"),
                new Word("of"),
                new Word("the"),
                new Word("rock"),
                new Word("upon"),
                new Word("which"),
                new Word("ye"),
                new Word("are"),
                new Word("built,"),
                new Word("which"),
                new Word("is"),
                new Word("a"),
                new Word("sure"),
                new Word("foundation,"),
                new Word("a"),
                new Word("foundation"),
                new Word("whereon"),
                new Word("if"),
                new Word("men"),
                new Word("build"),
                new Word("they"),
                new Word("cannot"),
                new Word("fall."),
            }),
        };
    }

    public Scripture GetRandomScripture()
    {
        if (scriptures.Count == 0)
        {
            Console.WriteLine("The scripture library is empty.");
            return null;
        }

        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);

        return scriptures[randomIndex];
    }
}
