using System;

string especieAnimal = "";
string idAnimal = "";
string idadeAnimal = "";
string descricaoFisicaAnimal = "";
string descricaoPersonalidadeAnimal = "";
string apelidoAnimal = "";

int maximoAnimais = 8;
string? resultadoLeitura;
string opcaoMenu = "";

// Os dados ficam apenas em memória e não são salvos ao encerrar o programa.
string[,] nossosAnimais = new string[maximoAnimais, 6];

for (int i = 0; i < maximoAnimais; i++)
{
    switch (i)
    {
        case 0:
            especieAnimal = "cachorro";
            idAnimal = "d1";
            idadeAnimal = "2";
            descricaoFisicaAnimal = "fêmea de golden retriever, porte médio, cor creme, com cerca de 65 libras. Acostumada a fazer as necessidades no lugar certo.";
            descricaoPersonalidadeAnimal = "adora carinho na barriga, gosta de perseguir o próprio rabo e distribui muitos lambeijos.";
            apelidoAnimal = "Lola";
            break;

        case 1:
            especieAnimal = "cachorro";
            idAnimal = "d2";
            idadeAnimal = "9";
            descricaoFisicaAnimal = "macho de golden retriever, porte grande, marrom-avermelhado, com cerca de 85 libras. Acostumado a fazer as necessidades no lugar certo.";
            descricaoPersonalidadeAnimal = "adora carinho nas orelhas ao receber você na porta — ou a qualquer hora! Gosta de se encostar e dar abraços.";
            apelidoAnimal = "Loki";
            break;

        case 2:
            especieAnimal = "gato";
            idAnimal = "c3";
            idadeAnimal = "1";
            descricaoFisicaAnimal = "fêmea pequena e branca, com cerca de 8 libras. Acostumada a usar a caixa de areia.";
            descricaoPersonalidadeAnimal = "amigável";
            apelidoAnimal = "Pus";
            break;

        case 3:
            especieAnimal = "gato";
            idAnimal = "c4";
            idadeAnimal = "?";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            apelidoAnimal = "";
            break;

        default:
            especieAnimal = "";
            idAnimal = "";
            idadeAnimal = "";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            apelidoAnimal = "";
            break;

    }

    nossosAnimais[i, 0] = "ID: " + idAnimal;
    nossosAnimais[i, 1] = "Espécie: " + especieAnimal;
    nossosAnimais[i, 2] = "Idade: " + idadeAnimal;
    nossosAnimais[i, 3] = "Apelido: " + apelidoAnimal;
    nossosAnimais[i, 4] = "Descrição física: " + descricaoFisicaAnimal;
    nossosAnimais[i, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;
}

do
{
    if (!Console.IsOutputRedirected)
    {
        Console.Clear();
    }

    Console.WriteLine("Bem-vindo ao aplicativo Amigos dos Pets Contoso. Opções do menu principal:");
    Console.WriteLine(" 1. Listar as informações de todos os animais");
    Console.WriteLine(" 2. Adicionar um novo animal à lista");
    Console.WriteLine(" 3. Completar as idades e descrições físicas dos animais");
    Console.WriteLine(" 4. Completar os apelidos e as descrições de personalidade dos animais");
    Console.WriteLine(" 5. Editar a idade de um animal");
    Console.WriteLine(" 6. Editar a personalidade de um animal");
    Console.WriteLine(" 7. Exibir gatos com uma característica específica");
    Console.WriteLine(" 8. Exibir cães com uma característica específica");
    Console.WriteLine();
    Console.WriteLine("Digite o número da opção (ou SAIR para encerrar o programa)");

    resultadoLeitura = Console.ReadLine();
    if (resultadoLeitura != null)
    {
        opcaoMenu = resultadoLeitura.ToLower(); 
    }

    switch (opcaoMenu)
    {
        case "1":
            for (int i = 0; i < maximoAnimais; i++)
            {
                if (nossosAnimais[i, 0] != "ID: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(nossosAnimais[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPressione Enter para continuar");
            resultadoLeitura = Console.ReadLine();

            break;

        case "2":
            string cadastrarOutro = "s";
            int quantidadeAnimais = 0;
            for (int i = 0; i < maximoAnimais; i++)
            {
                if (nossosAnimais[i, 0] != "ID: ")
                {
                    quantidadeAnimais += 1;
                }
            }

            if (quantidadeAnimais < maximoAnimais)
            {
                Console.WriteLine($"Temos {quantidadeAnimais} animais que precisam de um lar. Ainda podemos cuidar de mais {(maximoAnimais - quantidadeAnimais)}.");
            }

            while (cadastrarOutro == "s" && quantidadeAnimais < maximoAnimais)
            {
                bool entradaValida = false;
                
                do
                {
                    Console.WriteLine("\n\rDigite 'cachorro' ou 'gato' para iniciar um novo cadastro");
                    resultadoLeitura = Console.ReadLine();
                    if (resultadoLeitura != null)
                    {
                        especieAnimal = resultadoLeitura.ToLower();
                        if (especieAnimal != "cachorro" && especieAnimal != "gato")
                        {
                            entradaValida = false;
                        }
                        else
                        {
                            entradaValida = true;
                        }
                    }
                } while (entradaValida == false);

                idAnimal = especieAnimal.Substring(0, 1) + (quantidadeAnimais + 1).ToString();

                do
                {
                    int idadeDigitada;
                    Console.WriteLine("Digite a idade do animal ou ? se não souber");
                    resultadoLeitura = Console.ReadLine();
                    if (resultadoLeitura != null)
                    {
                        idadeAnimal = resultadoLeitura;
                        if (idadeAnimal != "?")
                        {
                            entradaValida = int.TryParse(idadeAnimal, out idadeDigitada);
                        }
                        else
                        {
                            entradaValida = true;
                        }
                    }
                } while (entradaValida == false);

                do
                {
                    Console.WriteLine("Descreva o animal (porte, cor, sexo, peso e hábitos de higiene)");
                    resultadoLeitura = Console.ReadLine();
                    if (resultadoLeitura != null)
                    {
                        descricaoFisicaAnimal = resultadoLeitura.ToLower();
                        if (descricaoFisicaAnimal == "")
                        {
                            descricaoFisicaAnimal = "tbd";
                        }
                    }
                } while (descricaoFisicaAnimal == "");

                do
                {
                    Console.WriteLine("Descreva a personalidade do animal (preferências, truques e nível de energia)");
                    resultadoLeitura = Console.ReadLine();
                    if (resultadoLeitura != null)
                    {
                        descricaoPersonalidadeAnimal = resultadoLeitura.ToLower();
                        if (descricaoPersonalidadeAnimal == "")
                        {
                            descricaoPersonalidadeAnimal = "tbd";
                        }
                    }
                } while (descricaoPersonalidadeAnimal == "");

                do
                {
                    Console.WriteLine("Digite um apelido para o animal");
                    resultadoLeitura = Console.ReadLine();
                    if (resultadoLeitura != null)
                    {
                        apelidoAnimal = resultadoLeitura.ToLower();
                        if (apelidoAnimal == "")
                        {
                            apelidoAnimal = "tbd";
                        }
                    }
                } while (apelidoAnimal == "");

                nossosAnimais[quantidadeAnimais, 0] = "ID: " + idAnimal;
                nossosAnimais[quantidadeAnimais, 1] = "Espécie: " + especieAnimal;
                nossosAnimais[quantidadeAnimais, 2] = "Idade: " + idadeAnimal;
                nossosAnimais[quantidadeAnimais, 3] = "Apelido: " + apelidoAnimal;
                nossosAnimais[quantidadeAnimais, 4] = "Descrição física: " + descricaoFisicaAnimal;
                nossosAnimais[quantidadeAnimais, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;

                quantidadeAnimais = quantidadeAnimais + 1;

                if (quantidadeAnimais < maximoAnimais)
                {
                    Console.WriteLine("Deseja cadastrar outro animal? (s/n)");
                    do
                    {
                        resultadoLeitura = Console.ReadLine();
                        if (resultadoLeitura != null)
                        {
                            cadastrarOutro = resultadoLeitura.ToLower();
                        }

                    } while (cadastrarOutro != "s" && cadastrarOutro != "n");
                }
            }

            if (quantidadeAnimais >= maximoAnimais)
            {
                Console.WriteLine("Atingimos o limite de animais que podemos cadastrar.");
                Console.WriteLine("Pressione Enter para continuar.");
                resultadoLeitura = Console.ReadLine();
            }

            break;

        case "3":
            for (int i = 0; i < maximoAnimais; i++)
            {
                if (nossosAnimais[i, 0] != "ID: ")
                {
                    string idPet = nossosAnimais[i, 0].Substring("ID: ".Length);
                    string idadeDigitada = nossosAnimais[i, 2].Substring("Idade: ".Length);
                    string descricaoFisicaPet = nossosAnimais[i, 4].Substring("Descrição física: ".Length);

                    if (idadeDigitada == "?" || idadeDigitada == "")
                    {
                        bool idadeValida = false;

                        do
                        {
                            Console.WriteLine($"Digite a idade de {idPet} (ou ? se não souber):");
                            resultadoLeitura = Console.ReadLine();

                            if (resultadoLeitura != null)
                            {
                                idadeDigitada = resultadoLeitura.Trim();
                                if (idadeDigitada == "?")
                                {
                                    idadeValida = true;
                                }
                                else if (int.TryParse(idadeDigitada, out int idadeConvertida))
                                {
                                    idadeValida = true;
                                }
                                else
                                {
                                    Console.WriteLine("Digite um número inteiro ou ?.");
                                }
                            }
                        } while (!idadeValida);

                        nossosAnimais[i, 2] = "Idade: " + idadeDigitada;
                    }

                    if (string.IsNullOrWhiteSpace(descricaoFisicaPet) || descricaoFisicaPet == "tbd")
                    {
                        do
                        {
                            Console.WriteLine($"Digite uma descrição física para {idPet}:");
                            resultadoLeitura = Console.ReadLine();

                            if (resultadoLeitura != null)
                            {
                                descricaoFisicaPet = resultadoLeitura.Trim();
                                if (descricaoFisicaPet == "")
                                {
                                    descricaoFisicaPet = "tbd";
                                }
                            }
                        } while (descricaoFisicaPet == "");

                        nossosAnimais[i, 4] = "Descrição física: " + descricaoFisicaPet;
                    }
                }
            }

            Console.WriteLine("As idades e descrições físicas dos animais estão completas.");
            Console.WriteLine("Pressione Enter para continuar.");
            resultadoLeitura = Console.ReadLine();
            break;

        case "4":
            for (int i = 0; i < maximoAnimais; i++)
            {
                if (nossosAnimais[i, 0] != "ID: ")
                {
                    string idPet = nossosAnimais[i, 0].Substring("ID: ".Length);
                    string apelidoPet = nossosAnimais[i, 3].Substring("Apelido: ".Length);
                    string personalidadePet = nossosAnimais[i, 5].Substring("Personalidade: ".Length);

                    if (string.IsNullOrWhiteSpace(apelidoPet) || apelidoPet == "tbd")
                    {
                        do
                        {
                            Console.WriteLine($"Digite um apelido para {idPet}:");
                            resultadoLeitura = Console.ReadLine();

                            if (resultadoLeitura != null)
                            {
                                apelidoPet = resultadoLeitura.Trim();
                                if (apelidoPet == "")
                                {
                                    apelidoPet = "tbd";
                                }
                            }
                        } while (apelidoPet == "");

                        nossosAnimais[i, 3] = "Apelido: " + apelidoPet;
                    }

                    if (string.IsNullOrWhiteSpace(personalidadePet) || personalidadePet == "tbd")
                    {
                        do
                        {
                            Console.WriteLine($"Digite uma descrição de personalidade para {idPet}:");
                            resultadoLeitura = Console.ReadLine();

                            if (resultadoLeitura != null)
                            {
                                personalidadePet = resultadoLeitura.Trim();
                                if (personalidadePet == "")
                                {
                                    personalidadePet = "tbd";
                                }
                            }
                        } while (personalidadePet == "");

                        nossosAnimais[i, 5] = "Personalidade: " + personalidadePet;
                    }
                }
            }

            Console.WriteLine("Os apelidos e as descrições de personalidade dos animais estão completos.");
            Console.WriteLine("Pressione Enter para continuar.");
            resultadoLeitura = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("Animais cadastrados:");
            bool existemAnimais = false;

            for (int i = 0; i < maximoAnimais; i++)
            {
                if (nossosAnimais[i, 0] != "ID: ")
                {
                    Console.WriteLine($"  {nossosAnimais[i, 0].Substring("ID: ".Length)}");
                    existemAnimais = true;
                }
            }

            if (!existemAnimais)
            {
                Console.WriteLine("Não há animais cadastrados.");
                Console.WriteLine("Pressione Enter para continuar.");
                resultadoLeitura = Console.ReadLine();
                break;
            }

            Console.WriteLine("Digite o ID do animal cuja idade deseja atualizar:");
            resultadoLeitura = Console.ReadLine();

            if (resultadoLeitura != null)
            {
                string idSelecionado = resultadoLeitura.Trim().ToLower();
                int indiceSelecionado = -1;

                for (int i = 0; i < maximoAnimais; i++)
                {
                    if (nossosAnimais[i, 0] != "ID: ")
                    {
                        string idAtual = nossosAnimais[i, 0].Substring("ID: ".Length).ToLower();
                        if (idAtual == idSelecionado)
                        {
                            indiceSelecionado = i;
                            break;
                        }
                    }
                }

                if (indiceSelecionado >= 0)
                {
                    string novaIdade = "";
                    bool idadeValida = false;

                    do
                    {
                        Console.WriteLine($"Digite a nova idade de {idSelecionado} ou ? se não souber:");
                        resultadoLeitura = Console.ReadLine();

                        if (resultadoLeitura != null)
                        {
                            novaIdade = resultadoLeitura.Trim();
                            if (novaIdade == "?" || int.TryParse(novaIdade, out int idadeConvertida))
                            {
                                idadeValida = true;
                            }
                            else
                            {
                                Console.WriteLine("Digite um número inteiro ou ?.");
                            }
                        }
                    } while (!idadeValida);

                    nossosAnimais[indiceSelecionado, 2] = "Idade: " + novaIdade;
                    Console.WriteLine($"Idade de {idSelecionado} atualizada.");
                }
                else
                {
                    Console.WriteLine("Nenhum animal foi encontrado com esse ID.");
                }
            }

            Console.WriteLine("Pressione Enter para continuar.");
            resultadoLeitura = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("Animais cadastrados:");
            existemAnimais = false;

            for (int i = 0; i < maximoAnimais; i++)
            {
                if (nossosAnimais[i, 0] != "ID: ")
                {
                    Console.WriteLine($"  {nossosAnimais[i, 0].Substring("ID: ".Length)}");
                    existemAnimais = true;
                }
            }

            if (!existemAnimais)
            {
                Console.WriteLine("Não há animais cadastrados.");
                Console.WriteLine("Pressione Enter para continuar.");
                resultadoLeitura = Console.ReadLine();
                break;
            }

            Console.WriteLine("Digite o ID do animal cuja personalidade deseja atualizar:");
            resultadoLeitura = Console.ReadLine();

            if (resultadoLeitura != null)
            {
                string idSelecionado = resultadoLeitura.Trim().ToLower();
                int indiceSelecionado = -1;

                for (int i = 0; i < maximoAnimais; i++)
                {
                    if (nossosAnimais[i, 0] != "ID: ")
                    {
                        string idAtual = nossosAnimais[i, 0].Substring("ID: ".Length).ToLower();
                        if (idAtual == idSelecionado)
                        {
                            indiceSelecionado = i;
                            break;
                        }
                    }
                }

                if (indiceSelecionado >= 0)
                {
                    string novaPersonalidade = "";
                    do
                    {
                        Console.WriteLine($"Digite a nova descrição de personalidade de {idSelecionado}:");
                        resultadoLeitura = Console.ReadLine();

                        if (resultadoLeitura != null)
                        {
                            novaPersonalidade = resultadoLeitura.Trim();
                            if (novaPersonalidade == "")
                            {
                                novaPersonalidade = "tbd";
                            }
                        }
                    } while (novaPersonalidade == "");

                    nossosAnimais[indiceSelecionado, 5] = "Personalidade: " + novaPersonalidade;
                    Console.WriteLine($"Personalidade de {idSelecionado} atualizada.");
                }
                else
                {
                    Console.WriteLine("Nenhum animal foi encontrado com esse ID.");
                }
            }

            Console.WriteLine("Pressione Enter para continuar.");
            resultadoLeitura = Console.ReadLine();
            break;
        
        case "7":
            Console.WriteLine("Digite uma característica para buscar nos gatos (por exemplo: branco, macho, brincalhão):");
            resultadoLeitura = Console.ReadLine();

            if (resultadoLeitura != null)
            {
                string caracteristica = resultadoLeitura.Trim().ToLower();
                bool encontrouCorrespondencia = false;

                for (int i = 0; i < maximoAnimais; i++)
                {
                    if (nossosAnimais[i, 0] != "ID: ")
                    {
                        string especie = nossosAnimais[i, 1].Substring("Espécie: ".Length).ToLower();
                        string descricaoFisica = nossosAnimais[i, 4].Substring("Descrição física: ".Length).ToLower();
                        string descricaoPersonalidade = nossosAnimais[i, 5].Substring("Personalidade: ".Length).ToLower();

                        if (especie == "gato" && (descricaoFisica.Contains(caracteristica) || descricaoPersonalidade.Contains(caracteristica)))
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(nossosAnimais[i, j]);
                            }
                            encontrouCorrespondencia = true;
                        }
                    }
                }

                if (!encontrouCorrespondencia)
                {
                    Console.WriteLine("Nenhum gato corresponde a essa característica.");
                }
            }

            Console.WriteLine("Pressione Enter para continuar.");
            resultadoLeitura = Console.ReadLine();
            break;

        case "8":
            Console.WriteLine("Digite uma característica para buscar nos cães (por exemplo: marrom, macho, amigável):");
            resultadoLeitura = Console.ReadLine();

            if (resultadoLeitura != null)
            {
                string caracteristica = resultadoLeitura.Trim().ToLower();
                bool encontrouCorrespondencia = false;

                for (int i = 0; i < maximoAnimais; i++)
                {
                    if (nossosAnimais[i, 0] != "ID: ")
                    {
                        string especie = nossosAnimais[i, 1].Substring("Espécie: ".Length).ToLower();
                        string descricaoFisica = nossosAnimais[i, 4].Substring("Descrição física: ".Length).ToLower();
                        string descricaoPersonalidade = nossosAnimais[i, 5].Substring("Personalidade: ".Length).ToLower();

                        if (especie == "cachorro" && (descricaoFisica.Contains(caracteristica) || descricaoPersonalidade.Contains(caracteristica)))
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(nossosAnimais[i, j]);
                            }
                            encontrouCorrespondencia = true;
                        }
                    }
                }

                if (!encontrouCorrespondencia)
                {
                    Console.WriteLine("Nenhum cão corresponde a essa característica.");
                }
            }

            Console.WriteLine("Pressione Enter para continuar.");
            resultadoLeitura = Console.ReadLine();
            break;

        default:
            break;
    }

} while (opcaoMenu != "sair");
