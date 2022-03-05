#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM ppc64le/mono:3.10-onbuild
CMD [ "mono",  "./TestingConsoleApp.exe" ]
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM ppc64le/mono:3.10-onbuild
CMD [ "mono",  "./TestingConsoleApp.exe" ]
WORKDIR /src
COPY ["SensoStatBO/SensoStatBO.csproj", "SensoStatBO/"]
RUN dotnet restore "SensoStatBO/SensoStatBO.csproj"
COPY . .
WORKDIR "/src/SensoStatBO"
RUN dotnet build "SensoStatBO.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SensoStatBO.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SensoStatBO.dll"]
