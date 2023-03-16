using AutoMapper;

namespace Ecommerce.Application.Common.MappingProfiles
{
    public static class MapperExtension
    {
        private static IMapper _mapper;


        public static IMapper RegisterMap(this IMapper mapper)
        {
            _mapper = mapper;
            return mapper;
        }


        public static TTarget MapTo<TTarget>(this object source)
        {
            return _mapper.Map<TTarget>(source);
        }

        public static List<TEntityDto> MapListTo<TEntityDto>(this object source)
        {
            return _mapper.Map<List<TEntityDto>>(source);
        }
        public static async Task<List<TEntityDto>> MapListAsyncTo<TEntityDto>(this object source)
        {
            return await _mapper.Map<Task<List<TEntityDto>>>(source);
        }
    }
}
