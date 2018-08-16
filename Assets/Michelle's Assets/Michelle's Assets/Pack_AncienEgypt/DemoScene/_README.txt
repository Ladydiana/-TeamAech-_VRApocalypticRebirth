To get the demo scenes working, you need to go to File > build setting and assing the level as :

0 - HomeScene
1 - Acient_Egypt_U5
2 - House_Inside
3 - Pyramid_Inside
4 - Temple_Inside


Update : Since Unity 2017 remove Javascript, the standard asset player controller are not longer included. To make the script work you Player prefab need to be with the "Player" tag. (See GameManager.cs) for more info.
