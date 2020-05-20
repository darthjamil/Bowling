# TDD
## Styles of Development WRT Testing
- **Code First**: Write all the code first, then write all the tests.
- **All Tests First**: Stub out the public interfaces, then write all the tests, then implement the code.
  - This way, you get to do some very high-fidelity planning before you code.
  - You also get to work out how a client would use your code.
- **Test Driven/First Development (TDD)**: Start with a failing test, then rapidly ping-pong between code and test until all use cases have been fulfilled.

## The Rules of TDD
1. First write a test that fails.  
   You have to write only that much of a test that will fail, no more.
1. Then write code to make it pass.  
   You have to choose the most degenerate way of making the test pass, no more.
1. Refactor if needed.
1. Repeat.

## The Benefits of TDD
- Even if we have 100% code coverage and full use-case coverage, we might still be missing a third dimension.
  - What if we write an acceptance test for `Save(user)` and `Load(userId)`. Then someone comes along and erases the code for `Save(user)` and changes `Load(userId)` to return a hard-coded object?
- You end up with tests that you can actually trust.
- You get 100% coverage, because you would not have written production code except in response to a failing test.
- If you find a bug, you can fix it with CTRL+Z.
- While your tests are testing your code, your code is testing your tests. That's because, for each test, you see it fail, then you see it pass, and the only thing you did in between was to write the very code that makes it pass.
- It encourages continuous refactoring / cleanup.
- It helps inform your architecture.

## Common Myths
- It takes longer to complete my work when using TDD.
  - ... because I'm writing throw-away tests and throw-away implementations.  
    *This is true, but only in the beginning of your coding session. It's really not that bad.*
  - ... because I'm constantly compiling, testing, and switching between test and code.  
    *It's a non-issue if you're using Live Unit Test.*
- I'm not used to it; it doesn't sound like my cup of tea.  
  *It does take some getting used to. But it becomes second nature pretty soon.*

## When is TDD Hard to do?
- When a solution is very large, like OS, it can take time for LUT to compile and run tests in the background. This can be really frustrating.  
  Trying targeting LUT to just your new test fixture. This *may* help a little.
- When you add features pretty much by trial-and-error. I.e. You make a change, see if it worked, and if it didn't you try to figure out why.  
  When you're new to a project, or the code is too large and complex, you end up coding like this. And it's really hard to do TDD in this case.

# The Demo
## The Rules of Bowling
https://www.pba.com/Resources/Bowling101

## The Code
```csharp
var game = new Game();

game.Roll(5);
game.Roll(3);
...

int score = game.Score();
```

## Sample Frame
![Sample Frame](https://camo.githubusercontent.com/ad2710d5e239994189d3f15d2d927225cf9a2b0a/687474703a2f2f7777772e7770636c69706172742e636f6d2f72656372656174696f6e2f73706f7274732f626f776c696e672f626f776c696e675f73636f726573686565745f6578616d706c652e706e67)
