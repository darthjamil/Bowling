# How to Play
## Rules for Scoring
https://www.pba.com/Resources/Bowling101

## Sample Frame
![Sample Frame](https://camo.githubusercontent.com/ad2710d5e239994189d3f15d2d927225cf9a2b0a/687474703a2f2f7777772e7770636c69706172742e636f6d2f72656372656174696f6e2f73706f7274732f626f776c696e672f626f776c696e675f73636f726573686565745f6578616d706c652e706e67)

# The Code
```csharp
var game = new Game();

game.Roll(5);
game.Roll(3);
...

int score = game.Score();
```

# TDD
## The Rules
1. You cannot write production code until you've written a failing test.
1. You can only write as much production code as is required to make the test pass.
1. Refactor if needed.
1. Repeat.

## The Benefits
- You end up with tests that you can trust.
- Test coverage is pretty much 100%.
- It encourages continuous refactoring / cleanup.
- It helps inform your architecture.

## Common Myths
- It takes longer to complete my work when using TDD.
- I'm not used to it; it doesn't sound like my cup of tea.
