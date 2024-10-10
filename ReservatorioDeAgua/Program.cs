Console.WriteLine("Insira o estado da boia A (false = Desligado, true = Ligado)");
		bool boiaA = bool.Parse(Console.ReadLine());
		Console.WriteLine("Insira o estado da boia B (false = Desligado, true = Ligado)");
		bool boiaB = bool.Parse(Console.ReadLine());
		Console.WriteLine("Insira o estado da boia C (false = Desligado, true = Ligado)");
		bool boiaC = bool.Parse(Console.ReadLine());
		if(boiaA == false && boiaB == true)
		{
			Console.WriteLine("Erro no sistema, chamar um tecnico");
		}
		else
		{
			if(boiaA == false && boiaB == false && boiaC == false || boiaA == false && boiaB == false && boiaC == true)
			{
				Console.WriteLine("Ligando a torneira da copasa");
				for (int c = 1; c < 4; c++)
				{
					Console.Write(".");
					Thread.Sleep(750);
				}
				Console.WriteLine(" Torneira Ligada!");
			}
			else
			{
				if(boiaA == true && boiaB == false && boiaC == false)
				{
					Console.WriteLine("Ligando a torneira da copasa");
					for (int c = 1; c < 4; c++)
					{
						Console.Write(".");
						Thread.Sleep(750);
					}
					Console.WriteLine(" Torneira Ligada!");
					Console.WriteLine("Ligando a bomba");
					for (int c = 1; c < 4; c++)
					{
						Console.Write(".");
						Thread.Sleep(750);
					}
					Console.WriteLine(" Bomba Ligada!");
				}
				else
				{
					if(boiaA == true && boiaB == false && boiaC == true)
					{
						Console.WriteLine("Ligando a torneira da copasa");
						Console.WriteLine("Desligando a bomba");
						for (int c = 1; c < 4; c++)
						{
							Console.Write(".");
							Thread.Sleep(750);
						}
						Console.WriteLine(" Bomba Desligada!");
					}
					else
					{
						if(boiaA == true && boiaB == true && boiaC == false)
						{
							Console.WriteLine("Desligando a torneira da copasa");
							for (int c = 1; c < 4; c++)
							{
								Console.Write(".");
								Thread.Sleep(750);
							}
							Console.WriteLine(" Torneira Desligada!");
							Console.WriteLine("Ligando a bomba");
							for (int c = 1; c < 4; c++)
							{
								Console.Write(".");
								Thread.Sleep(750);
							}
							Console.WriteLine(" Bomba Ligada!");
						}
						else
						{
						    Console.WriteLine("Todas os reservatorios estão cheios, sistema funcionando perfeitamente");
						}
					}
				}
			}
		}