FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /app

COPY production .

EXPOSE 5000

CMD ["dotnet", "ViteApi.dll"]