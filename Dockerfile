FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["CircleCalculator.csproj", "./"]
RUN dotnet restore "CircleCalculator.csproj"

COPY . .
RUN dotnet publish "CircleCalculator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "CircleCalculator.dll"]