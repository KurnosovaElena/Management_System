using BLL.Services.Interfaсes;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Implementaiton;
public class LabelService (ILabelRepository repository) : ILabelService
{
    public async Task<LabelEntity> Add(LabelEntity entity, CancellationToken cancellationToken)
    {
        await repository.Add(entity, cancellationToken);

        return entity;
    }

    public async Task<LabelEntity> GetById(Guid id, CancellationToken cancellationToken)
    {
        var label = await repository.GetLabel(id, cancellationToken);

        return label;
    }

    public async Task<IEnumerable<LabelEntity>> GetAll(CancellationToken cancellationToken)
    {
        var labels = await repository.GetAll(cancellationToken);
        return labels;
    }

    public async Task<LabelEntity> Update(Guid id, LabelEntity entity, CancellationToken cancellationToken)
    {
        var label = await repository.GetLabel(id, cancellationToken);

        await repository.Update(label, cancellationToken);

        return entity;
    }

    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var label = await repository.GetLabel(id, cancellationToken);

        await repository.Delete(label, cancellationToken);
    }
}