
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vhaNetCoreLab11_EF.Models;
using vhaNetCoreLab11_EF.Entities;

public class vhaCategoriesController : Controller
{
    private readonly vhaAppDbContext _context;

    public vhaCategoriesController(vhaAppDbContext context)
    {
        _context = context;
    }

    // GET: VHACATEGORYS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.categories.ToListAsync());
    }

    // GET: VHACATEGORYS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var vhacategory = await _context.categories
            .FirstOrDefaultAsync(m => m.Id == id);
        if (vhacategory == null)
        {
            return NotFound();
        }

        return View(vhacategory);
    }

    // GET: VHACATEGORYS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: VHACATEGORYS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,Status,CreatedDate")] vhaCategory vhacategory)
    {
        if (ModelState.IsValid)
        {
            vhacategory.CreatedDate = DateTime.Now;
            _context.Add(vhacategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(vhacategory);
    }

    // GET: VHACATEGORYS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var vhacategory = await _context.categories.FindAsync(id);
        if (vhacategory == null)
        {
            return NotFound();
        }
        return View(vhacategory);
    }

    // POST: VHACATEGORYS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Name,Status,CreatedDate")] vhaCategory vhacategory)
    {
        if (id != vhacategory.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                vhacategory.CreatedDate = DateTime.Now;
                _context.Update(vhacategory);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VhaCategoryExists(vhacategory.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(vhacategory);
    }

    // GET: VHACATEGORYS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var vhacategory = await _context.categories
            .FirstOrDefaultAsync(m => m.Id == id);
        if (vhacategory == null)
        {
            return NotFound();
        }

        return View(vhacategory);
    }

    // POST: VHACATEGORYS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var vhacategory = await _context.categories.FindAsync(id);
        if (vhacategory != null)
        {
            _context.categories.Remove(vhacategory);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool VhaCategoryExists(int? id)
    {
        return _context.categories.Any(e => e.Id == id);
    }
}
