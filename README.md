# TDD
## The Rules
1. First you write a test that fails.  
   You have to write only that much of a test that will fail, no more.
1. Then you write code to make it pass.  
   You have to choose the most degenerate way of making the test pass, no more.
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
