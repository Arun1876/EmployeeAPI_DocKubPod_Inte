#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["EmployeeWEBAPI_DK_Interation.csproj", ""]
RUN dotnet restore "EmployeeWEBAPI_DK_Interation.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "EmployeeWEBAPI_DK_Interation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EmployeeWEBAPI_DK_Interation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeeWEBAPI_DK_Interation.dll"]