using back.Model;

namespace back.Context
{
    public class TecnologiaInitializer
    {
        public static void PopularTecnologias(ApplicationDbContext context)
        {
            if (context.Tecnologias.Any())
            {
                return;
            }

            var tecnologias = new Tecnologia[]
            {
                new Tecnologia
                {
                    Linguagem = "Java",
                    Imagem = "https://upload.wikimedia.org/wikipedia/en/thumb/3/30/Java_programming_language_logo.svg/182px-Java_programming_language_logo.svg.png",
                    Documentacao= "https://www.oracle.com/java/technologies/javase-documentation.html",
                    VideoAulas = "https://www.youtube.com/watch?v=VKjFuX91G5Q&list=PL62G310vn6nFIsOCC0H-C2infYgwm8SWW",
                    RoadMap = "https://roadmap.sh/java"
                },
                new Tecnologia
                {
                    Linguagem = "C#",
                    Imagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/C_Sharp_wordmark.svg/180px-C_Sharp_wordmark.svg.png",
                    Documentacao= "https://learn.microsoft.com/pt-br/",
                    VideoAulas = "https://www.youtube.com/watch?v=dVzJ3bx68FA&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi",
                    RoadMap = "https://github.com/MoienTajik/AspNetCore-Developer-Roadmap"
                },
                new Tecnologia
                {
                    Linguagem = "Python",
                    Imagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/182px-Python-logo-notext.svg.png",
                    Documentacao= "https://docs.python.org/pt-br/3/tutorial/",
                    VideoAulas = "https://www.youtube.com/watch?v=S9uPNppGsGo&list=PLvE-ZAFRgX8hnECDn1v9HNTI71veL3oW0",
                    RoadMap = "https://roadmap.sh/python"
                },
                new Tecnologia
                {
                    Linguagem = "JavaScript",
                    Imagem = "https://logodownload.org/wp-content/uploads/2022/04/javascript-logo-2048x2048.png",
                    Documentacao= "https://developer.mozilla.org/pt-BR/docs/Web/JavaScript",
                    VideoAulas = "https://www.youtube.com/watch?v=BXqUH86F-kA&list=PLntvgXM11X6pi7mW0O4ZmfUI1xDSIbmTm",
                    RoadMap = "https://roadmap.sh/javascript"
                },
                new Tecnologia
                {
                    Linguagem = "Golang",
                    Imagem = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Go_Logo_Blue.svg/322px-Go_Logo_Blue.svg.png",
                    Documentacao= "https://go.dev/doc/",
                    VideoAulas = "https://www.youtube.com/watch?v=WiGU_ZB-u0w&list=PLCKpcjBB_VlBsxJ9IseNxFllf-UFEXOdg",
                    RoadMap = "https://roadmap.sh/golang"
                }
            };

            foreach (Tecnologia t in tecnologias)
            {
                context.Tecnologias.Add(t);
            }
            context.SaveChanges();
        }
    }
}