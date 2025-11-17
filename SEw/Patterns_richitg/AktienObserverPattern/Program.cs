using AktienObserverPattern;

Apple aktie1 = new Apple();

AppleInvestor john = new ();
AppleInvestor jane = new ();

aktie1.Register(john);
aktie1.Register(jane);

aktie1.Change();

aktie1.Unregister(jane);
aktie1.Change();