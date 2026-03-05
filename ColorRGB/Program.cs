using System;

// README.md를 읽고 코드를 작성하세요.


ColorRGB R = new ColorRGB(255, 0, 0);
ColorRGB W = new ColorRGB(255, 255, 255);
ColorRGB B = new ColorRGB(100, 150, 200);



Console.WriteLine("=== RGB 색상 밝기 계산 ===");
Console.WriteLine($"빨강 - R: {R.R}, G: {R.G}, B: {R.B} -> 밝기: {GetBrightness(R)}");
Console.WriteLine($"흰색 - R: {W.R}, G: {W.G}, B: {W.B} -> 밝기: {GetBrightness(W)}");
Console.WriteLine($"커스텀 - R: {B.R}, G: {B.G}, B: {B.B} -> 밝기: {GetBrightness(B)}");


int GetBrightness(ColorRGB color)
{
    return (color.R + color.G + color.B) / 3;
}

