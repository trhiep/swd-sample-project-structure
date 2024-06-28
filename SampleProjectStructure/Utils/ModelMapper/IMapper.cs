﻿namespace SampleProjectStructure.Utils.ModelMapper
{
    public interface IMapper<TEntity, TDto>
    {
        TDto ToDto(TEntity entity);
        TEntity ToEntity(TDto dto);
    }
}
