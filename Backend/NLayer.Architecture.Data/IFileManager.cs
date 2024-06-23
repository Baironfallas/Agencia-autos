﻿
namespace NLayer.Architecture.Data;

public interface IFileRepository
{
    //metodo para leer un json
    Task<T> ReadJsonFileAsync<T>(string filePath);

    Task<List<T>> ReadListJsonAsync<T>(string filePath);

    Task WriteJsonFileAsync<T>(string filePath, T data);
}
