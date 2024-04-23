do
{
          string nome;
          double peso;
          float altura;
          int idade;


          Console.WriteLine("CALCULADORA DE IMC E IDADE\n");

          // Pegando o nome
          Console.WriteLine("\nPor favor, digite seu nome");
          nome = Console.ReadLine();


          // Pegando a altura
          Console.WriteLine("\nAgora digite sua altura, por favor:");
          altura = float.Parse(Console.ReadLine());
          

          // Pegando o peso
          Console.WriteLine("\nAgora digite seu peso, por favor:");
          peso = Convert.ToDouble(Console.ReadLine());


          // Pegando a idade
          Console.WriteLine("\nAgora digite sua idade, por favor:");
          idade = Convert.ToInt32(Console.ReadLine());






          //  Classificando a idade do usuário
          string classIdade;

          if (idade < 10){
                    classIdade = "Criança";
          }
          else if(idade < 20){
                    classIdade = "Adolescente";
          }
          else if (idade < 60){
                    classIdade = "Adulto";
          }
          else{
                    classIdade = "Idoso";
          }


          // Calculando e classificando o IMC
          string classIMC;

          double alturaX = altura * altura;
          double IMC = peso / alturaX;

          if(IMC < 18.5){
                    classIMC = "Abaixo do peso";
          }
          else if(IMC >= 18.5 && IMC<= 24.9){
                    classIMC = "Peso normal";
          }
          else if(IMC >= 25 && IMC <= 29.9){
                    classIMC= "Sobrepeso";
          }
          else {
                    classIMC = "Obesidade";
          }



          // Gerando o relatório
          Console.WriteLine($"\n\nRELATÓRIO\n---------------------\n\nNome:{nome}\nIdade:{idade}\nAltura:{altura}\nPeso:{peso}\n\nConstatamos que na sua idade, sendo um(a) {classIdade}, sua classificação de IMC foi calculada como {classIMC}.\n");


          // Deixando um recado ao usuário com o switch
          switch(classIMC){
                    case "Abaixo do peso":
                              Console.WriteLine("Recomento que inicie uma alimentação mais adequada e regular, pois estar abaixo do peso no IMC diz que você corre ridscos de pressão e anemia devido a falta de alimentação");
                    break;
                    case "Peso normal":
                              Console.WriteLine("Mantenha a sia alimentação como está fazendo e continue com boa saúde!!");
                    break;
                    case"Sobrepeso":
                              Console.WriteLine("Recomendo que tome cuidado com sua saúde, pelo resultado você está com o sobrepeso. Comece a cuidar de sua saude.");
                    break;
                    default:
                              Console.WriteLine("Sua classificação ficou como obesidade, portanto recomendo que cuide mais de sua saúde pois a obesidade pode trazer grandes riscos a sua saúde.");
                    break;
          }

          Console.WriteLine("\n-------------------------------------------------------------------------\n\n");


          // Questionando o usuário se deseja fazer outro teste
          string resposta;

          while(true){
                    Console.WriteLine("Deseja realizar o teste de IMC novamente?(S/N)");
                    resposta = Console.ReadLine().ToLower();
                    if(resposta == "s"|| resposta == "n"){
                              break;
                    }else{
                              Console.WriteLine("Não entendi sua resposta");
                              continue;
                    }
          }

          if(resposta == "s"){
                    continue;
          }
          else if(resposta == "n"){
                    break;
          }
}
while (true);
