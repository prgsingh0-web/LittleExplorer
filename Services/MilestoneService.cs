using Microsoft.EntityFrameworkCore;
using ToddlerActivityPlanner.Data;
using ToddlerActivityPlanner.Models;

namespace ToddlerActivityPlanner.Services;

public class MilestoneService
{
    private readonly AppDbContext _db;

    public MilestoneService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Milestone>> GetAllAsync(int childId)
    {
        return await _db.Milestones
            .Where(m => m.ChildId == childId)
            .OrderBy(m => m.Category)
            .ThenBy(m => m.Title)
            .ToListAsync();
    }

    public async Task AddAsync(Milestone milestone)
    {
        _db.Milestones.Add(milestone);
        await _db.SaveChangesAsync();
    }

    public async Task ToggleCompletedAsync(int id)
    {
        var milestone = await _db.Milestones.FindAsync(id);

        if (milestone != null)
        {
            milestone.IsCompleted = !milestone.IsCompleted;

            milestone.DateCompleted = milestone.IsCompleted
                ? DateTime.Now
                : null;

            await _db.SaveChangesAsync();
        }
    }

    public async Task DeleteAsync(int id)
    {
        var milestone = await _db.Milestones.FindAsync(id);

        if (milestone != null)
        {
            _db.Milestones.Remove(milestone);
            await _db.SaveChangesAsync();
        }
    }

    
public async Task SeedDefaultMilestonesAsync(int childId, int age)
{
    var existing = await _db.Milestones.AnyAsync(m => m.ChildId == childId);

    if (existing)
    {
        return;
    }

    var milestones = new List<Milestone>();

    if (age <= 1)
    {
        milestones.AddRange(new[]
        {
            new Milestone { ChildId = childId, Title = "Smiles socially", Category = "Social", AgeRange = "0-1 year" },
            new Milestone { ChildId = childId, Title = "Makes eye contact", Category = "Social", AgeRange = "0-1 year" },
            new Milestone { ChildId = childId, Title = "Responds to parent's voice", Category = "Cognitive", AgeRange = "0-1 year" },
            new Milestone { ChildId = childId, Title = "Holds head steady", Category = "Motor Skills", AgeRange = "0-1 year" },
            new Milestone { ChildId = childId, Title = "Rolls over", Category = "Motor Skills", AgeRange = "0-1 year" },
            new Milestone { ChildId = childId, Title = "Reaches for toys", Category = "Motor Skills", AgeRange = "0-1 year" },
            new Milestone { ChildId = childId, Title = "Laughs aloud", Category = "Emotional", AgeRange = "0-1 year" },
            new Milestone { ChildId = childId, Title = "Sits without support", Category = "Motor Skills", AgeRange = "0-1 year" },
            new Milestone { ChildId = childId, Title = "Responds to own name", Category = "Language", AgeRange = "0-1 year" },
            new Milestone { ChildId = childId, Title = "Says mama or dada", Category = "Language", AgeRange = "0-1 year" }
        });
    }
    else if (age <= 2)
    {
        milestones.AddRange(new[]
        {
            new Milestone { ChildId = childId, Title = "Walks independently", Category = "Motor Skills", AgeRange = "1-2 years" },
            new Milestone { ChildId = childId, Title = "Runs with support", Category = "Motor Skills", AgeRange = "1-2 years" },
            new Milestone { ChildId = childId, Title = "Climbs onto furniture", Category = "Motor Skills", AgeRange = "1-2 years" },
            new Milestone { ChildId = childId, Title = "Stacks 4 to 6 blocks", Category = "Cognitive", AgeRange = "1-2 years" },
            new Milestone { ChildId = childId, Title = "Uses spoon with help", Category = "Motor Skills", AgeRange = "1-2 years" },
            new Milestone { ChildId = childId, Title = "Says 20 plus words", Category = "Language", AgeRange = "1-2 years" },
            new Milestone { ChildId = childId, Title = "Follows simple instructions", Category = "Cognitive", AgeRange = "1-2 years" },
            new Milestone { ChildId = childId, Title = "Points to body parts", Category = "Cognitive", AgeRange = "1-2 years" },
            new Milestone { ChildId = childId, Title = "Shows affection", Category = "Emotional", AgeRange = "1-2 years" },
            new Milestone { ChildId = childId, Title = "Begins pretend play", Category = "Social", AgeRange = "1-2 years" }
        });
    }
    else if (age <= 3)
    {
        milestones.AddRange(new[]
        {
            new Milestone { ChildId = childId, Title = "Uses 3 to 4 word sentences", Category = "Language", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Counts to 5", Category = "Cognitive", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Knows basic colors", Category = "Cognitive", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Runs confidently", Category = "Motor Skills", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Jumps with both feet", Category = "Motor Skills", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Kicks a ball", Category = "Motor Skills", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Draws a circle", Category = "Cognitive", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Washes hands with help", Category = "Motor Skills", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Plays beside other children", Category = "Social", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Asks simple questions", Category = "Language", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Names familiar objects", Category = "Language", AgeRange = "2-3 years" },
            new Milestone { ChildId = childId, Title = "Shows independence", Category = "Emotional", AgeRange = "2-3 years" }
        });
    }
    else
    {
        milestones.AddRange(new[]
        {
            new Milestone { ChildId = childId, Title = "Counts to 10", Category = "Cognitive", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Recognizes shapes", Category = "Cognitive", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Speaks clearly in sentences", Category = "Language", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Tells simple stories", Category = "Language", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Hops on one foot", Category = "Motor Skills", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Balances briefly", Category = "Motor Skills", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Draws a person", Category = "Cognitive", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Dresses with little help", Category = "Motor Skills", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Shares toys", Category = "Social", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Understands emotions", Category = "Emotional", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Follows multi-step instructions", Category = "Cognitive", AgeRange = "3-5 years" },
            new Milestone { ChildId = childId, Title = "Recognizes some letters", Category = "Cognitive", AgeRange = "3-5 years" }
        });
    }

    _db.Milestones.AddRange(milestones);
    await _db.SaveChangesAsync();
}

}