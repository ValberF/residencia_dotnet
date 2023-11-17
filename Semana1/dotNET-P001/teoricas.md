# Questão 1

Utilizando o comando "dotnet --list-sdks" são exibidas todas as versões do .NET SDK instaladas,
se ao menos 1 versão for retornada no terminal, conclui-se que existe um .NET SDK instalado corretamente
no sistema. 

Para atualizar a versão do .NET SDK, utiliza-se o comando "dotnet tool update" + 
PACKAGE_ID, que é o NOME/ID do pacote NuGet que contém a ferramenta do .NET a ser atualizada,

Para remover uma .NET SDK no Windows basta utilizar a ferramenta de adicionar e remover programas do Windows,
procurar pelo "Microsoft .NET SDK 'versão do sdk'" e desinstalar o SDK, enquanto no Ubuntu existe o comando
"sudo apt-get remove dotnet-sdk-versão-que-deseja-remover".

# Questão 2

Tipos inteiros númericos no .NET:

- sbyte
- byte
- short
- ushort
- int
- uint
- long
- ulong

Os mais variados tipos de inteiros podem ser utilizados de acordo com a necessidade do programador,
já que alguns ocupam menos espaço na memória do que outros, por exemplo, o sbyte e o byte tem o tamanho de
8 bits, com a diferença que o sbyte vai de -128 a 127 e o byte vai de 0 a 255, algo semelhante ocorre entre os próximos exemplos como o short e o ushort, em que ambos tem 16 bits de tamanho, porém o short vai de -32768 a 
32767 e o ushort de 0 a 65535, o int e o uint ocupam 32 bits, onde o int vai de -2147483648 a 2147483647 e o 
uint 0 a 4294967295, finalizando com o long e o ulong, com tamanho de 64 bits, com o long indo de 
-9223372036854775808 a 9223372036854775807 e o ulong de 0 a 18446744073709551615.

Exemplos:
```
sbyte varSbyte = -23;
byte varByte = 143;
short varShort = -2391;
ushort varUShort = 1352;
int varInt = -327890;
uint varUInt = 257381;
long varLong = -42345678456789;
ulong varULong = 1844674073709551615;
```