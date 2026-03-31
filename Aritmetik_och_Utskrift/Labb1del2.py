def recept(a):
    print(str(round(3*a/4)) + " ägg. \n"
          + str(3*a/4) + " dl strösocker. \n"
          + str(2*a/4) + " tsk vaniljsocker. \n"
          + str(2*a/4) + " tsk bakpulver. \n"
          + str(3*a/4) + " dl vetemjöl. \n"
          + str(75*a/4) + " gram smör. \n"
          + str(a/4) + " dl vatten.")

def tidblanda(a):
    blanda=10+a
    return blanda

def tidgradda(a):
    gradda=30+3*a
    return gradda

def sockerkaka(a):
    print("Det här är antalet ingredienser för " + str(a)
          + " personer,\nom du tänkte baka en sockerkaka!")
    recept(a)
    tid = tidblanda(a) + tidgradda(a)
    return "Detta kommer ta " + str(tid) + " minuter."

print(str(sockerkaka(4) + "\n"))
print(str(sockerkaka(7)))
