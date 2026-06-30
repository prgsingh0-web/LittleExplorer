namespace ToddlerActivityPlanner.Services;
using ToddlerActivityPlanner.Models;

public static class MilestoneLibrary
{
    public static List<Milestone> GetAllMilestones()
    {
        return new List<Milestone>
        {
            // =========================
            // 0-1 YEAR
            // =========================

            new() { Title="Smiles socially", Category="Social", AgeRange="0-1 year" },
            new() { Title="Makes eye contact", Category="Social", AgeRange="0-1 year" },
            new() { Title="Responds to parent's voice", Category="Language", AgeRange="0-1 year" },
            new() { Title="Responds to own name", Category="Language", AgeRange="0-1 year" },
            new() { Title="Laughs aloud", Category="Emotional", AgeRange="0-1 year" },

            new() { Title="Holds head steady", Category="Motor Skills", AgeRange="0-1 year" },
            new() { Title="Rolls over", Category="Motor Skills", AgeRange="0-1 year" },
            new() { Title="Sits without support", Category="Motor Skills", AgeRange="0-1 year" },
            new() { Title="Crawls", Category="Motor Skills", AgeRange="0-1 year" },
            new() { Title="Pulls to stand", Category="Motor Skills", AgeRange="0-1 year" },

            new() { Title="Reaches for toys", Category="Cognitive", AgeRange="0-1 year" },
            new() { Title="Explores objects", Category="Cognitive", AgeRange="0-1 year" },
            new() { Title="Recognizes familiar faces", Category="Cognitive", AgeRange="0-1 year" },

            // =========================
            // 1-2 YEARS
            // =========================

            new() { Title="Walks independently", Category="Motor Skills", AgeRange="1-2 years" },
            new() { Title="Runs with support", Category="Motor Skills", AgeRange="1-2 years" },
            new() { Title="Climbs onto furniture", Category="Motor Skills", AgeRange="1-2 years" },
            new() { Title="Uses spoon with help", Category="Motor Skills", AgeRange="1-2 years" },

            new() { Title="Says 20+ words", Category="Language", AgeRange="1-2 years" },
            new() { Title="Points to body parts", Category="Language", AgeRange="1-2 years" },
            new() { Title="Follows simple instructions", Category="Language", AgeRange="1-2 years" },

            new() { Title="Stacks 4-6 blocks", Category="Cognitive", AgeRange="1-2 years" },
            new() { Title="Matches simple objects", Category="Cognitive", AgeRange="1-2 years" },
            new() { Title="Identifies familiar people", Category="Cognitive", AgeRange="1-2 years" },

            new() { Title="Shows affection", Category="Emotional", AgeRange="1-2 years" },
            new() { Title="Begins pretend play", Category="Social", AgeRange="1-2 years" },
            new() { Title="Plays beside other children", Category="Social", AgeRange="1-2 years" },

            // =========================
            // 2-3 YEARS
            // =========================

            new() { Title="Uses 3-4 word sentences", Category="Language", AgeRange="2-3 years" },
            new() { Title="Names familiar objects", Category="Language", AgeRange="2-3 years" },
            new() { Title="Knows colors", Category="Language", AgeRange="2-3 years" },
            new() { Title="Counts to 5", Category="Language", AgeRange="2-3 years" },
            new() { Title="Asks simple questions", Category="Language", AgeRange="2-3 years" },

            new() { Title="Runs confidently", Category="Motor Skills", AgeRange="2-3 years" },
            new() { Title="Jumps with both feet", Category="Motor Skills", AgeRange="2-3 years" },
            new() { Title="Kicks a ball", Category="Motor Skills", AgeRange="2-3 years" },
            new() { Title="Walks upstairs", Category="Motor Skills", AgeRange="2-3 years" },

            new() { Title="Draws a circle", Category="Cognitive", AgeRange="2-3 years" },
            new() { Title="Recognizes shapes", Category="Cognitive", AgeRange="2-3 years" },
            new() { Title="Sorts objects by color", Category="Cognitive", AgeRange="2-3 years" },

            new() { Title="Shows independence", Category="Emotional", AgeRange="2-3 years" },
            new() { Title="Expresses emotions", Category="Emotional", AgeRange="2-3 years" },

            new() { Title="Shares toys", Category="Social", AgeRange="2-3 years" },
            new() { Title="Takes turns while playing", Category="Social", AgeRange="2-3 years" },

            // =========================
            // 3-5 YEARS
            // =========================

            new() { Title="Counts to 10", Category="Language", AgeRange="3-5 years" },
            new() { Title="Speaks clearly", Category="Language", AgeRange="3-5 years" },
            new() { Title="Tells simple stories", Category="Language", AgeRange="3-5 years" },

            new() { Title="Hops on one foot", Category="Motor Skills", AgeRange="3-5 years" },
            new() { Title="Balances briefly", Category="Motor Skills", AgeRange="3-5 years" },
            new() { Title="Skips", Category="Motor Skills", AgeRange="3-5 years" },

            new() { Title="Draws a person", Category="Cognitive", AgeRange="3-5 years" },
            new() { Title="Recognizes numbers", Category="Cognitive", AgeRange="3-5 years" },
            new() { Title="Solves simple puzzles", Category="Cognitive", AgeRange="3-5 years" },

            new() { Title="Shows empathy", Category="Emotional", AgeRange="3-5 years" },
            new() { Title="Controls emotions better", Category="Emotional", AgeRange="3-5 years" },

            new() { Title="Makes friends", Category="Social", AgeRange="3-5 years" },
            new() { Title="Works in groups", Category="Social", AgeRange="3-5 years" }
        };
    }
}