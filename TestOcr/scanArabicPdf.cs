//using IronOcr;
//using static System.Net.Mime.MediaTypeNames;

//var Ocr = new IronTesseract();
//Ocr.Language = OcrLanguage.Arabic;
//using (var input = new OcrInput())
//{
//    input.AddPdf("test1.pdf", "password");
//    // We can also select specific PDF page numnbers to OCR
//    var Result = Ocr.Read(input);
//    Console.WriteLine(Result.Text);
//    await File.WriteAllTextAsync("WriteText.txt", Result.Text);
//    Console.WriteLine($"{Result.Pages.Count()} Pages");
//    //Result.SaveAsSearchablePdf(Result.Text);
//    // 1 page for every page of the PDF
//}