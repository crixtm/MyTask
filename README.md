This Readme is for making run Krisztián Barabás's solution according to the shared task 

Needed softwares:
Visual Studio
Git client (I used Git Bash)
Recomennded extensions:
Nunit 3 test adapter
Specflow for MS Visual Studio x

Steps to start
1. Start Git Bash
2. Clone the solution
3. Open App.Config and set the desired folder of the screenshots
4. Open App.Config ans set the browser what you want to test. Currently only Chrome is the only supported one.
3. Start Visual Studio 
4. Open the solution
5. Open Test explorer
6. Build the solution (F6)
7. Run all test (Ctrl R, A)

One of the LogoOnPageFeature's testcases should fail. The initial intention is to check Error handling