
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vha2410900007_exam.Models;

public class VhaStudentsController : Controller
{
    private readonly VhaStudent2410900007DbContext _context;

    public VhaStudentsController(VhaStudent2410900007DbContext context)
    {
        _context = context;
    }

    // GET: VHASTUDENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.VhaStudents.ToListAsync());
    }

    // GET: VHASTUDENTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var vhastudent = await _context.VhaStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (vhastudent == null)
        {
            return NotFound();
        }

        return View(vhastudent);
    }

    // GET: VHASTUDENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: VHASTUDENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,VhaName,VhaGender,VhaBirthDay,VhaEmail,VhaPhone,VhaActive")] VhaStudent vhastudent)
    {
        if (ModelState.IsValid)
        {
            _context.Add(vhastudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(vhastudent);
    }

    // GET: VHASTUDENTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var vhastudent = await _context.VhaStudents.FindAsync(id);
        if (vhastudent == null)
        {
            return NotFound();
        }
        return View(vhastudent);
    }

    // POST: VHASTUDENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,VhaName,VhaGender,VhaBirthDay,VhaEmail,VhaPhone,VhaActive")] VhaStudent vhastudent)
    {
        if (id != vhastudent.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(vhastudent);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VhaStudentExists(vhastudent.Id))
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
        return View(vhastudent);
    }

    // GET: VHASTUDENTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var vhastudent = await _context.VhaStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (vhastudent == null)
        {
            return NotFound();
        }

        return View(vhastudent);
    }

    // POST: VHASTUDENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var vhastudent = await _context.VhaStudents.FindAsync(id);
        if (vhastudent != null)
        {
            _context.VhaStudents.Remove(vhastudent);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool VhaStudentExists(int? id)
    {
        return _context.VhaStudents.Any(e => e.Id == id);
    }
}
