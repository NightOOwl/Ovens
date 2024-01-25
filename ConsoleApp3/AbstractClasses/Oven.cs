using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Oven<TProduct> where TProduct : Material
    {
        private List<ICombustible> _fuel = new List<ICombustible>();
        private List<IProcessableTo<TProduct>> _source = new List<IProcessableTo<TProduct>>();
        private List<TProduct> _product = new List<TProduct>();

        public int Capacity => 64;

        public abstract float Efficiency { get; }

        public IReadOnlyList<ICombustible> Fuel => _fuel.AsReadOnly();

        public IReadOnlyList<IProcessableTo<TProduct>> Source => _source.AsReadOnly();

        public IReadOnlyList<TProduct> Product => _product.AsReadOnly();

        public virtual async Task HeatTreat()
        {
            if (_fuel.Count > 0 && _source.Count > 0 && _product.Count < Capacity)
            {
                double temperature = Efficiency * _fuel.Last().HeatCapacity;

                // Запускаем горение топлива
                Task burnTask = _fuel.Last().Burn();

                // Проверяем наличие следующего объекта топлива
                ICombustible nextFuel = _fuel.Count > 1 ? _fuel[_fuel.Count - 2] : null;

                // Запускаем обработку сырья, передавая время горения следующего топлива
                Task<TProduct> processTask = _source.Last().Process(temperature, nextFuel?.CombustionTime ?? TimeSpan.Zero);

                // Ожидаем завершения обоих задач
                await Task.WhenAll(burnTask, processTask);

                // Добавляем обработанный продукт
                TProduct processedProduct = await processTask;
                _product.Add(processedProduct);
            }
            else
            {
                throw new InvalidOperationException("Invalid operation");
            }
        }


        // Специальные методы для добавления и извлечения из коллекций
        public void AddFuel(IEnumerable<ICombustible> combustibles)
        {
            // Добавление проверок и логики, если необходимо
            _fuel.AddRange(combustibles);
        }

        public void AddSource(IEnumerable<IProcessableTo<TProduct>> processables)
        {
            // Добавление проверок и логики, если необходимо
            _source.AddRange(processables);
        }

        public List<ICombustible> ExtractFuel(int count)
        {
            return Extract(_fuel, count);
        }

        public List<IProcessableTo<TProduct>> ExtractSource(int count)
        {
            return Extract(_source, count);
        }

        public List<TProduct> ExtractProduct(int count)
        {
            return Extract(_product, count);
        }

        private List<T> Extract<T>(List<T> collection, int count)
        {
            if (count <= 0)
            {
                return new List<T>();
            }

            int itemsToExtract = Math.Min(count, collection.Count);
            List<T> extractedItems = collection.GetRange(collection.Count - itemsToExtract, itemsToExtract);
            collection.RemoveRange(collection.Count - itemsToExtract, itemsToExtract);

            return extractedItems;
        }
    }
}
