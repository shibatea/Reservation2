using System.Threading.Tasks;
using 会議室予約.Domain;
using 会議室予約.Domain.Exceptions;
using 会議室予約.UseCase.Exceptions;
using 会議室予約.UseCase.Repository;

namespace 会議室予約.UseCase
{
    public class 疑似ユースケースクラス
    {
        private readonly I予約Repository _repository;

        public 疑似ユースケースクラス(I予約Repository repository)
        {
            _repository = repository;
        }


        
        public async Task 会議室予約するAsync(予約Request request)
        {
            try
            {
                var よやく = new 予約(request.よやくしゃ,
                    request.りようきかん,
                    request.かいぎしつ,
                    request.かいぎさんかよていしゃ,
                    new 予約可能ルール());
                            
                await _repository.Add(よやく);
            }
            catch (ルール違反Exception ex)
            {  
                // エラーで返す。
                throw new UseCaseException(ex);
            }

            // 終了
        }
    }
}