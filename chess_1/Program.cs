global using Raylib_cs;
global using System.Numerics;

bool turn = true;       //ifall bollian är true då är det vitas drag ifall den är false då är det svartas drag

Raylib.InitWindow(640, 640, "Chess");
Raylib.SetTargetFPS(60);

Texture2D bkgImage = Raylib.LoadTexture("board_bkg.png");
int size = 80;

List<Pawn> whitePawns = new List<Pawn>(); //lista för vita pawns
List<Pawn> blackPawns = new List<Pawn>(); //lista för svarta pawns

for (int x = 0; x < 8; x++) //placerar ut vita pawns
{
    whitePawns.Add(new Pawn(x, 6, true));
}

for (int x = 0; x < 8; x++) //placerar ut svarta pawns
{
    blackPawns.Add(new Pawn(x, 1, true));
}

string currentScene = "start"; //scenes start, game, end

//LOGIK
while (Raylib.WindowShouldClose() == false)
{
    if (currentScene == "game")
    {
        if (turn == true)
        {
            // ändrar på vita
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP))
            {
                //whitePawns.gridPosY--;
                //whitePawns.Update();
            }
        }
        else
        {

        }
    }
    else if (currentScene == "start")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            currentScene = "game";
        }
    }
    else if (currentScene == "end")
    {

    }

    //GRAFIK

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    if (currentScene == "game")
    {
        Raylib.DrawTexture(bkgImage, 0, 0, Color.WHITE);

        // whitePawn.Draw();
        for (int x = 0; x < 8; x++)
        {
        whitePawns[x].Draw();
        }
        for (int x = 0; x < 8; x++)
        {
        blackPawns[x].Draw();   
        }
        
    }

    else if (currentScene == "start")
    {
        Raylib.DrawText("Welcome to the Game of Chess", 80, 200, 32, Color.BLACK);
        Raylib.DrawText("Press ENTER to Start the Game", 70, 300, 32, Color.BLACK);

    }

    else if (currentScene == "end")
    {

    }


    Raylib.EndDrawing();
}
