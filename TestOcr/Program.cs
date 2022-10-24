using IronOcr;


var Ocr = new IronTesseract();
Ocr.Language = OcrLanguage.Arabic;
using (var Input = new OcrInput(@"arabicLowquality.jpg"))
{
    Input.Deskew(); // removes rotation and perspective
    var Result = Ocr.Read(Input);
    await File.WriteAllTextAsync("WriteText.txt", Result.Text);
    Console.WriteLine(Result.Text);
}

