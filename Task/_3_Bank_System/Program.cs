using System;

namespace _3_Bank_System
{
	/*
	public class account
	{
		private int acNo;
		public int _acNo
		{
			set
			{
				acNo = value;
			}
			get
			{
				return acNo;
			}
		}

		private string name;
		public string _name
		{
			set
			{
				name = value;
			}
			get
			{
				return name;
			}
		}

		private int deposit;
		public int _deposit
		{
			set
			{
				deposit = value;
			}
			get
			{
				return deposit;
			}
		}

		public char type;


		public void create_account()
		{
			Console.Write("\t\t\tEnter the Account No. : ");
			_acNo = int.Parse(Console.ReadLine());

			Console.Write("\n\t\t\tEnter the Name of the Account holder : ");
			_name = Console.ReadLine();

			Console.Write("\n\t\t\tEnter Type of the Account (C/S) : ");
			type = char.Parse(Console.ReadLine());
			type = char.ToUpper(type);

			Console.Write("\n\t\t\tEnter The Initial amount : ");
			_deposit = int.Parse(Console.ReadLine());


			show_account();

			Console.Write("\n\t\t\tAccount Created..");
		}


		public void show_account()
		{
			Console.Write("\n\t\t\tAccount No. : ");
			Console.Write(_acNo);
			Console.Write("\n\t\t\tAccount Holder Name : ");
			Console.Write(_name);
			Console.Write("\n\t\t\tType of Account : ");
			Console.Write(type);
			Console.Write("\n\t\t\tBalance amount : ");
			Console.Write(_deposit);
		}

		public void modify()
		{
			Console.Write("\n\t\t\tAccount No. : ");
			Console.Write(_acNo);
			Console.Write("\n\t\t\tModify Account Holder Name : ");

			name = Console.ReadLine();
			Console.Write("\n\t\t\tModify Type of Account : ");
			type = char.Parse(Console.ReadLine());
			type = char.ToUpper(type);
			Console.Write("\n\t\t\tModify Balance amount : ");
			_deposit = int.Parse(Console.ReadLine());
		}
		public void dep(int x)
		{
			_deposit += x;
		}
		public void draw(int x)
		{
			_deposit -= x;
		}
		//C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
		//ORIGINAL LINE: void report() const
		public void report()
		{
			Console.Write(_acNo);
			Console.Write("{0,10}", " ");
			Console.Write("{0}", name);
			Console.Write("{0,10}", " ");
			Console.Write("{0}", type);
			Console.Write("{0,6}", deposit);
			Console.Write("{0}", "\n");
		}
		public int retacno()
		{
			return _acNo;
		}
		public int retdeposit()
		{
			return deposit;
		}
		public char rettype()
		{
			return type;
		}
	}

	public static class GlobalMembers
	{
		public static void write_account()
		{
			account ac = new account();
			ac.create_account();
		}

		public static void display_sp(int n)
		{
			account ac = new account();
			bool flag = false;

			Console.Write("\n\t\t\tBALANCE DETAILS\n");

			if (ac.retacno() == n)
			{
				ac.show_account();
				flag = true;
			}
			if (flag == false)
			{
				Console.Write("\n\n\t\t\tAccount number does not exist");
			}
		}

		public static void modify_account(int n)
		{
			bool found = false;
			account ac = new account();

			if (ac.retacno() == n)
			{
				ac.show_account();
				Console.Write("\n\n\t\t\tEnter The New Details of account");
				Console.Write("\n");
				ac.modify();
				Console.Write("\n\n\t\t\tRecord Updated");
				found = true;
			}

			if (found == false)
			{
				Console.Write("\n\n\t\t\tRecord Not Found ");
			}
		}

		public static void delete_account(int n)
		{
			account ac = new account();
			Console.Write("\n\nRecord Deleted ..");
		}

		public static void display_all()
		{
			account ac = new account();

			Console.Write("\n\n\t\tACCOUNT HOLDER LIST\n\n");
			Console.Write("====================================================\n");
			Console.Write("A/c no.      NAME           Type  Balance\n");
			Console.Write("====================================================\n");
			ac.report();
		}

		public static void deposit_withdraw(int n, int option)
		{
			int amt;
			bool found = false;
			account ac = new account();
			Console.WriteLine("Account No : " + ac._acNo);
			ac.show_account();

			if (ac.retacno() == n)
			{
				ac.show_account();
				if (option == 1)
				{
					Console.Write("\n\n\t\t\tTO DEPOSITSS AMOUNT");
					Console.Write("\n\n\t\t\tEnter The amount to be deposited: ");
					amt = int.Parse(Console.ReadLine());
					ac.dep(amt);
				}
				if (option == 2)
				{
					Console.Write("\n\n\t\t\tTO WITHDRAW AMOUNT");
					Console.Write("\n\n\t\t\tEnter The amount to be withdraw: ");
					amt = int.Parse(Console.ReadLine());
					int bal = ac.retdeposit() - amt;
					if (bal < 0)
					{
						Console.Write("Insufficience balance");
					}
					else
					{
						ac.draw(amt);
					}
				}
				Console.Write("\n\n\t\t\tRecord Updated");
				found = true;
			}
			if (found == false)
			{
				Console.Write("\n\n\t\t\tRecord Not Found ");
			}
		}

		public static void DetailOfAccount(int num)
		{
			account ac = new account();
			if (ac.retacno() == num)
			{
				ac.show_account();
			}
			else
			{
				Console.WriteLine(ac.retacno());
				Console.WriteLine("No Record");
			}
		}

		static int Main()
		{
			char ch;
			int num;
			do
			{
				Console.Write("\n\n\t\t\t\t======================\n");
				Console.Write("\t\t\t\tBANK MANAGEMENT SYSTEM");
				Console.Write("\n\t\t\t\t======================\n");

				Console.Write("\t\t\t\t    ::MAIN MENU::\n");
				Console.Write("\n\t\t\t\t1. NEW ACCOUNT");
				Console.Write("\n\t\t\t\t2. Detail of AMOUNT");
				//Console.Write("\n\t\t\t\t2. DEPOSIT AMOUNT");
				//Console.Write("\n\t\t\t\t3. WITHDRAW AMOUNT");
				//Console.Write("\n\t\t\t\t4. BALANCE ENQUIRY");
				//Console.Write("\n\t\t\t\t5. ALL ACCOUNT HOLDER LIST");
				//Console.Write("\n\t\t\t\t6. CLOSE AN ACCOUNT");
				//Console.Write("\n\t\t\t\t7. MODIFY AN ACCOUNT");
				//Console.Write("\n\t\t\t\t8. EXIT");
				Console.Write("\n\n\t\t\t\tSelect Your Option (1-2): ");
				ch = char.Parse(Console.ReadLine());

				switch (ch)
				{
					case '1':
						write_account();
						break;
					case '2':
						//Console.Write("\n\n\t\t\tEnter The account No. : ");
						//num = int.Parse(Console.ReadLine());
						//deposit_withdraw(num, 1);
						Console.Write("\n\n\t\t\tEnter The account No. : ");
						num = int.Parse(Console.ReadLine());
						DetailOfAccount(num);
						break;
					//case '3':
					//	Console.Write("\n\n\t\t\tEnter The account No. : ");
					//	num = int.Parse(Console.ReadLine());
					//	deposit_withdraw(num, 2);
					//	break;
					//case '4':
					//	Console.Write("\n\n\t\t\tEnter The account No. : ");
					//	num = int.Parse(Console.ReadLine());
					//	display_sp(num);
					//	break;
					//case '5':
					//	display_all();
					//	break;
					//case '6':
					//	Console.Write("\n\n\t\t\tEnter The account No. : ");
					//	num = int.Parse(Console.ReadLine());
					//	delete_account(num);
					//	break;
					//case '7':
					//	Console.Write("\n\n\t\t\tEnter The account No. : ");
					//	num = int.Parse(Console.ReadLine());
					//	modify_account(num);
					//	break;
					//case '8':
					//	Console.Write("\n\n\t\t\tBrought To You By code-projects.org");
					//	break;
					default:
						Console.Write("\a");
						break;
				}
				Console.ReadLine();
			} while (ch != '8');
			return 0;
		}

	}

	
	internal static class ConsoleInput
	{m
		private static bool goodLastRead = false;
		public static bool LastReadWasGood
		{
			get
			{
				return goodLastRead;
			}
		}

		public static string ReadToWhiteSpace(bool skipLeadingWhiteSpace)
		{
			string input = "";

			char nextChar;
			while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
			{
				//accumulate leading white space if skipLeadingWhiteSpace is false:
				if (!skipLeadingWhiteSpace)
					input += nextChar;
			}
			//the first non white space character:
			input += nextChar;

			//accumulate characters until white space is reached:
			while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
			{
				input += nextChar;
			}

			goodLastRead = input.Length > 0;
			return input;
		}

		public static string ScanfRead(string unwantedSequence = null, int maxFieldLength = -1)
		{
			string input = "";

			char nextChar;
			if (unwantedSequence != null)
			{
				nextChar = '\0';
				for (int charIndex = 0; charIndex < unwantedSequence.Length; charIndex++)
				{
					if (char.IsWhiteSpace(unwantedSequence[charIndex]))
					{
						//ignore all subsequent white space:
						while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
						{
						}
					}
					else
					{
						//ensure each character matches the expected character in the sequence:
						nextChar = (char)System.Console.Read();
						if (nextChar != unwantedSequence[charIndex])
							return null;
					}
				}

				input = nextChar.ToString();
				if (maxFieldLength == 1)
					return input;
			}

			while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
			{
				input += nextChar;
				if (maxFieldLength == input.Length)
					return input;
			}

			return input;
		}
	}
	
	*/

	internal class Program
    {







        static void Main(string[] args)
        {
			

        }
    }
}
