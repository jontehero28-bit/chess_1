
public class Pawn
{
    Texture2D pawnW = Raylib.LoadTexture("chessPieces/pawn.png");
    Texture2D pawnB = Raylib.LoadTexture("chessPieces/pawn1.png");
    Vector2 pawnWPos = new Vector2();
    Vector2 pawnBPos = new Vector2();

    public int gridPosX = 7;
    public int gridPosY = 1;

    int gridSize = 80;

    bool isWhite;

    public Pawn(int x, int y, bool white)
    {
        gridPosX = x;
        gridPosY = y;
        isWhite = white;
        Update();
    }

    public void Update()
    {
        pawnWPos.X = (gridSize * gridPosX) + (gridSize / 2) - (pawnW.width / 2);
        pawnWPos.Y = (gridSize * gridPosY) + (gridSize / 2) - (pawnW.height / 2);

        pawnBPos.X = (gridSize * gridPosX) + (gridSize / 2) - (pawnB.width / 2);
        pawnBPos.Y = (gridSize * gridPosY) + (gridSize / 2) - (pawnB.height / 2);
    }

    public void Draw()
    {
        if (isWhite)
        {
            Raylib.DrawTextureEx(pawnW, pawnWPos, 0, 1, Color.WHITE);
        }
        else
        {
            Raylib.DrawTextureEx(pawnB, pawnBPos, 0, 1, Color.WHITE);
        }
    }

}
